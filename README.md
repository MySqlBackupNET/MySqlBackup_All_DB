# MySqlBackup_All_DB
A tool to backup &amp; restore all databases in one click

## Download
https://github.com/MySqlBackupNET/MySqlBackup_All_DB/releases

Language: C#<br />
Platform: WinForm

## Backup
This tool is mainly using MySqlBackup.NET (github, codeproject) as core library to perform the backup/restore work.

A typical code block to backup one specific pre-defined database will be something like this:

```C#
string connstr = "server=localhost;user=root;pwd=1234;database=db1;sslmode=none;convertdatetime=true;";
string backupfile = "C:\\backup.sql";

using (MySqlConnection conn = new MySqlConnection(connstr))
{
    using (MySqlCommand cmd = new MySqlCommand())
    {
        using (MySqlBackup mb = new MySqlBackup(cmd))
        {
            conn.Open();
            cmd.Connection = conn;

            mb.ExportToFile(backupfile);

            conn.Close();
        }
    }
}
```
In order to backup all databases, we'll need to get a list of databases and loop through them one by one to perform the backup work.

This SQL command will get the list:

```
show databases;
```
Example of code block in C#:
```c#
string connstr = "server=localhost;user=root;pwd=1234;sslmode=none;convertdatetime=true;";

using (MySqlConnection conn = new MySqlConnection(connstr))
{
    using (MySqlCommand cmd = new MySqlCommand())
    {
        using (MySqlBackup mb = new MySqlBackup(cmd))
        {
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "show databases;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtDbList = new DataTable();
            da.Fill(dtDbList);

            conn.Close();
        }
    }
}
```
Next, we loop through the databases one by one to perform the backup work:

```c#
cmd.CommandText = "show databases;";
MySqlDataAdapter da = new MySqlDataAdapter(cmd);
DataTable dtDbList = new DataTable();
da.Fill(dtDbList);

string defaultFolder = "C:\\backup_folder";

foreach(DataRow dr in dtDbList.Rows)
{
    string dbname = dr[0] + "";
    
    // skip mysql default system tables
    switch (dbname)
    {
        case "sys":
        case "performance_schema":
        case "mysql":
        case "information_schema":
            continue;
    }
    
    string dumpFile = System.IO.Path.Combine(defaultFolder, dbname) + ".sql";

    cmd.CommandText = "use `" + dbname + "`;";
    cmd.ExecuteNonQuery();

    mb.ExportToFile(dumpFile);
}
```
## Restore
For the restore task, loop through all the backup files and perform the restore one by one.

Code for getting a list of backup files (dump files):

```c#
string defaultBackupFolder = "C:\\backup_folder";
string[] files = System.IO.Directory.GetFiles(defaultBackupFolder);

foreach (string file in files)
{
    if (file.ToLower().EndsWith(".sql"))
    {
        // Perform backup
    }
}
```
Begin of restoration of database:

```c#
foreach (string file in files)
{
    if (file.ToLower().EndsWith(".sql"))
    {
        string dbName = System.IO.Path.GetFileNameWithoutExtension(file);

        cmd.CommandText = "create database if not exists `" + dbName + "`";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "use `" + dbName + "`";
        cmd.ExecuteNonQuery();

        mb.ImportFromFile(file);
    }
}
```
The full code block will be something like this:

```c#
string connstr = "server=localhost;user=root;pwd=1234;sslmode=none;convertdatetime=true;";

using (MySqlConnection conn = new MySqlConnection(connstr))
{
    using (MySqlCommand cmd = new MySqlCommand())
    {
        using (MySqlBackup mb = new MySqlBackup(cmd))
        {
            conn.Open();
            cmd.Connection = conn;

            string defaultBackupFolder = "C:\\backup_folder";
            string[] files = System.IO.Directory.GetFiles(defaultBackupFolder);

            foreach (string file in files)
            {
                if (file.ToLower().EndsWith(".sql"))
                {
                    string dbName = System.IO.Path.GetFileNameWithoutExtension(file);

                    cmd.CommandText = "create database if not exists `" + dbName + "`";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "use `" + dbName + "`";
                    cmd.ExecuteNonQuery();

                    mb.ImportFromFile(file);
                }
            }

            conn.Close();
        }
    }
}
```
The sample project that I have included in this page is presented in WinForm. If the backup or restore process takes a long time, the program will be frozen and has the high possibility to have the Time Out (more than 60 seconds) error.

One of the possible solution is by running the process using BackgroundWorker so that the process will be executed on separate thread.

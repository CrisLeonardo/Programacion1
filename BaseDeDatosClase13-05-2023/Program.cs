//crear tabla 
using Microsoft.Data.Sqlite;
void createTable()
{
    using (var connection = new SqliteConnection("Data Source=hello.db"))
    {
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = @"
        CREATE TABLE user (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT )
        ";
        command.ExecuteNonQuery();
    }
}
//crear tabla 

void readTable(String id )
{
    using (var connectin = new SqliteConnection("Data Source=hello.db"))
    {
        connectin.Open();
        var command = connectin.CreateCommand();
        command.CommandText = @"
        Select name 
        from user
        where id = $id
            
        ";
        command.Parameters.AddWithValue("$id", id);
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var name = reader.GetString(0);
                Console.WriteLine($"Hola{name}");
            }
        }
    }
}

void InsertTable(String name)
{
    using (var connectin = new SqliteConnection("Data Source=hello.db"))
    {
        connectin.Open();
        var command = connectin.CreateCommand();
        command.CommandText = @"
        INSERT INTO user (name)
        VALUES ($name)   
        ";
        command.Parameters.AddWithValue("$name", name);
        command.ExecuteNonQuery();
        
    }
}

void updateTable(String id,String name)
{
    using (var connectin = new SqliteConnection("Data Source=hello.db"))
    {
        connectin.Open();
        var command = connectin.CreateCommand();
        command.CommandText = @"
        UPDATE user
        SET nmae = $name
        WHERE id = $id
        ";
        command.Parameters.AddWithValue("$id", id);
        command.Parameters.AddWithValue("$name", name);
        command.ExecuteNonQuery();

    }
}

void deleteTable(String id, String name)
{
    using (var connectin = new SqliteConnection("Data Source=hello.db"))
    {
        connectin.Open();
        var command = connectin.CreateCommand();
        command.CommandText = @"
        DELETE FROM user
        WHERE id = $id
        ";
        command.Parameters.AddWithValue("$id", id);
        command.ExecuteNonQuery();

    }
}

void readAllRecorsTable()
{
    using (var connectin = new SqliteConnection("Data Source=hello.db"))
    {
        connectin.Open();
        var command = connectin.CreateCommand();
        command.CommandText = @"
        Select id,name 
        from user
        ";
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                Console.WriteLine($"ID:{id} - {name}");
            }
        }
    }
}

//createTable();
//InsertTable("Bob");
//InsertTable("Pepito");
InsertTable("carlo");
InsertTable("marcelo");
readTable("2");
readTable("1");
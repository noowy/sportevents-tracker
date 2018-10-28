using System.Data.SQLite;
using System.Collections.Generic;

namespace SportEventsLab.Data.Input
{
	static class Handler
	{
		//  Method gets data from given fields from database 	
		public static List<string>[] GetFieldsFromDataBase(params string[] fields)
		{
			string dbConnectionString = "Data Source=sport_events.sqlite;Version=3";
			string dbCommand = "";
			List<string>[] data = new List<string>[fields.Length];

			SQLiteConnection dataBase = new SQLiteConnection(dbConnectionString);
			dataBase.Open();

			for (int i = 0; i < fields.Length; i++)
			{
				data[i] = new List<string>();
				dbCommand = "select " + fields[i] + " from SportEvents";
				SQLiteDataReader rawData = new SQLiteCommand(dbCommand, dataBase).
					ExecuteReader();
				while (rawData.Read())
				{
					data[i].Add(rawData[$"{fields[i]}"] as string);
				}
				rawData.Close();
			}
			
			dataBase.Close();
			return data;
		}

		//  Method gets one single entry from DB with given name
		public static List<string> GetEntryFromDataBase(string eventName)
		{
			List<string> requestedEvent = new List<string>();
			string dbConnectionString = "Data Source=sport_events.sqlite;Version=3";
			string dbCommand = "select Type, League, Name, Date, Winner " +
							   "from SportEvents where Name='" + eventName + "';";

			SQLiteConnection dataBase = new SQLiteConnection(dbConnectionString);
			dataBase.Open();

			SQLiteDataReader rawEntry = new SQLiteCommand(dbCommand, dataBase).
				ExecuteReader();
			rawEntry.Read();
			requestedEvent.Add(rawEntry[$"Type"] as string);
			requestedEvent.Add(rawEntry[$"League"] as string);
			requestedEvent.Add(rawEntry[$"Name"] as string);
			requestedEvent.Add(rawEntry[$"Date"] as string);
			requestedEvent.Add(rawEntry[$"Winner"] as string);
			rawEntry.Close();

			dataBase.Close();
			return requestedEvent;
		}
	}
}
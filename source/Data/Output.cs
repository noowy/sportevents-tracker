using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SportEventsLab.Data.Output
{
	static class Handler
	{
		//  Method adds new entry to database (overloaded)
		public static void SaveToDataBase(string[] eventInfo)
		{
			string dbConnectionString = "Data Source=sport_events.sqlite;Version=3";
			string dbCommand = "";

			SQLiteConnection dataBase = new SQLiteConnection(dbConnectionString);
			dataBase.Open();

			dbCommand = "insert into SportEvents (Type, League, Name, Date, Winner)" +
						" values (" +
						"'" + eventInfo[0] + "', " +
						"'" + eventInfo[1] + "', " +
						"'" + eventInfo[2] + "', " +
						"'" + eventInfo[3] + "', " +
						"'" + eventInfo[4] + "')";
			new SQLiteCommand(dbCommand, dataBase).ExecuteNonQuery();
			dataBase.Close();
		}

		//  Method modifies data at entry with given name (overloaded)S
		public static void SaveToDataBase(string entryToModify, string[] eventInfo)
		{
			string dbConnectionString = "Data Source=sport_events.sqlite;Version=3";
			string dbCommand = "";

			SQLiteConnection dataBase = new SQLiteConnection(dbConnectionString);
			dataBase.Open();

			dbCommand = "update SportEvents set " +
						"Type = '" + eventInfo[0] + "', " +
						"League = '" + eventInfo[1] + "', " +
						"Name = '" + eventInfo[2] + "', " +
						"Date = '" + eventInfo[3] + "', " +
						"Winner = '" + eventInfo[4] + "' " +
						"where Name = '" + entryToModify + "';";
			new SQLiteCommand(dbCommand, dataBase).ExecuteNonQuery();
			dataBase.Close();
		}

		//  Method extracts data from DB and saves it to a text file 
		public static void SaveToTextFile(string fileName)
		{
			string[] fields = { "Type", "League", "Name", "Date", "Winner" };
			List<string>[] events = Input.Handler.GetFieldsFromDataBase(fields);

			for (int i = 0; i < events[0].Count; i++)
			{
				using (StreamWriter txtFile = new StreamWriter(fileName, true))
				{
					txtFile.WriteLine(events[0][i]);
					txtFile.WriteLine(events[1][i]);
					txtFile.WriteLine(events[2][i]);
					txtFile.WriteLine(events[3][i]);
					txtFile.WriteLine(events[4][i] + Environment.NewLine);
				}
			}
		}
	}
}
/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Account_Name]
      ,[FirstName]
      ,[LastName]
      ,[Email]
      ,[IncidentDescription]
  FROM [TestIncidentDb].[dbo].[Incidents]
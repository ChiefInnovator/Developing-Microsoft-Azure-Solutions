CREATE TABLE [dbo].[BoardUser]
(
  [UserId] INT NOT NULL,
  [Email] NVARCHAR(1024) NOT NULL,
  [Name] NVARCHAR(255) NOT NULL,
  [LastWorkout] DATETIME NOT NULL,
  CONSTRAINT [PK_Board] PRIMARY KEY CLUSTERED ([UserId]),
)

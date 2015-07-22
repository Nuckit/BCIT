CREATE TABLE [dbo].[Task] (
    [TaskId]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]            VARCHAR (50) NOT NULL,
    [CategoryId]      INT          NOT NULL,
    [StartDate]       DATETIME     NOT NULL,
    [DueDate]         DATETIME     NOT NULL,
    [Completed]       BIT          NOT NULL,
    [Priority]        INT          NOT NULL,
    [PercentComplete] INT          NOT NULL,
    [Username]        VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([TaskId] ASC),
    CONSTRAINT [FK_Task_ToCategory] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId])
);


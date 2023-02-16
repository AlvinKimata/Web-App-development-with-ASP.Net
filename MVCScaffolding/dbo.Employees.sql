CREATE TABLE [dbo].[Employees] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (60) NULL,
    [Joiningdate] DATETIME       NOT NULL,
    [age]         INT            NOT NULL,
    CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED ([ID] ASC)
);


CREATE TABLE [Client](
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Nome] NVARCHAR(180) NOT NULL,
    [Cpf] NVARCHAR(50) NOT NULL,
    [Birthday] DATETIME NOT NULL,
    [Email] NVARCHAR(150) NOT NULL,
    [Phone] NVARCHAR(30) NOT NULL,
    [Activated] BIT NOT NULL DEFAULT(0), 

    CONSTRAINT [Pk_Client] PRIMARY KEY ([Id])
)
GO

CREATE TABLE [LitaryGenre](
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [NameOfGenre] NVARCHAR(100) NOT NULL,
    [Favorite] BIT NOT NULL,

    CONSTRAINT [PK_LitaryGenre] PRIMARY KEY ([Id])
)
GO

CREATE TABLE [Book](
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Title] NVARCHAR(180) NOT NULL,
    [ISBN] NVARCHAR(100) NOT NULL,
    [Author] NVARCHAR(180) NOT NULL,
    [Publisher] NVARCHAR(180) NOT NULL,
    [YearOfPublication] DATETIME NOT NULL,
    [LitaryGenreId] UNIQUEIDENTIFIER NOT NULL, 

    CONSTRAINT [PK_Book] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Book_LitaryGenre] FOREIGN KEY ([LitaryGenreId])
        REFERENCES [LitaryGenre]([Id])
)
GO

CREATE TABLE [ClientBook](
    [ClientId] UNIQUEIDENTIFIER NOT NULL,
    [BookId] UNIQUEIDENTIFIER NOT NULL,
    [StartDate] DATETIME NOT NULL,
    [Order] TINYINT NOT NULL,

    CONSTRAINT [PK_ClientBook] PRIMARY KEY ([ClientId], [BookId]),
    CONSTRAINT [FK_ClientBook_Client_ClientId] FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id]),
    CONSTRAINT [FK_ClientBooks_Book_BookId] FOREIGN KEY ([BookId]) REFERENCES [Book]([Id])
)
GO
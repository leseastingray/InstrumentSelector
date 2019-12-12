IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191212041733_Initial')
BEGIN
    CREATE TABLE [Instruments] (
        [InstrumentID] int NOT NULL IDENTITY,
        [Size] nvarchar(max) NULL,
        [Range] nvarchar(max) NULL,
        [RangeDescription] nvarchar(max) NULL,
        [Tone] nvarchar(max) NULL,
        [ToneDescription] nvarchar(max) NULL,
        [Technical] nvarchar(max) NULL,
        [DescriptionText] nvarchar(max) NULL,
        CONSTRAINT [PK_Instruments] PRIMARY KEY ([InstrumentID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191212041733_Initial')
BEGIN
    CREATE TABLE [Comments] (
        [CommentID] int NOT NULL IDENTITY,
        [CommentText] nvarchar(max) NULL,
        [CommentTime] datetime2 NOT NULL,
        [UserName] nvarchar(max) NULL,
        [Instrument] nvarchar(max) NULL,
        [InstrumentID] int NULL,
        CONSTRAINT [PK_Comments] PRIMARY KEY ([CommentID]),
        CONSTRAINT [FK_Comments_Instruments_InstrumentID] FOREIGN KEY ([InstrumentID]) REFERENCES [Instruments] ([InstrumentID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191212041733_Initial')
BEGIN
    CREATE TABLE [Selections] (
        [SelectionID] int NOT NULL IDENTITY,
        [PreferredSize] nvarchar(max) NULL,
        [PreferredRange] nvarchar(max) NULL,
        [PreferredTone] nvarchar(max) NULL,
        [PreferredTechnical] nvarchar(max) NULL,
        [PreferredInstrumentInstrumentID] int NULL,
        [SecondInstrumentInstrumentID] int NULL,
        CONSTRAINT [PK_Selections] PRIMARY KEY ([SelectionID]),
        CONSTRAINT [FK_Selections_Instruments_PreferredInstrumentInstrumentID] FOREIGN KEY ([PreferredInstrumentInstrumentID]) REFERENCES [Instruments] ([InstrumentID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Selections_Instruments_SecondInstrumentInstrumentID] FOREIGN KEY ([SecondInstrumentInstrumentID]) REFERENCES [Instruments] ([InstrumentID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191212041733_Initial')
BEGIN
    CREATE INDEX [IX_Comments_InstrumentID] ON [Comments] ([InstrumentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191212041733_Initial')
BEGIN
    CREATE INDEX [IX_Selections_PreferredInstrumentInstrumentID] ON [Selections] ([PreferredInstrumentInstrumentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191212041733_Initial')
BEGIN
    CREATE INDEX [IX_Selections_SecondInstrumentInstrumentID] ON [Selections] ([SecondInstrumentInstrumentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191212041733_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191212041733_Initial', N'2.2.6-servicing-10079');
END;

GO


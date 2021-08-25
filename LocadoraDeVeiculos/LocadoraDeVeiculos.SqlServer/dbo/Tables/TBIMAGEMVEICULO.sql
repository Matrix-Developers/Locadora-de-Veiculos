﻿CREATE TABLE [dbo].[TBIMAGEMVEICULO] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [id_veiculo] INT             NOT NULL,
    [imagem]     VARBINARY (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBIMAGEMVEICULO_TBVEICULO] FOREIGN KEY ([id_veiculo]) REFERENCES [dbo].[TBVEICULO] ([Id]) ON DELETE CASCADE
);


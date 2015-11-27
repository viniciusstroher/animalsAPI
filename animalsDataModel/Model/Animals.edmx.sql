
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/15/2015 15:20:25
-- Generated from EDMX file: C:\Users\Vinicius\Desktop\animalsAPI\animalsDataModel\Model\Animals.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SaveAPet];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__RegistroA__IdEst__173876EA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroAnimal] DROP CONSTRAINT [FK__RegistroA__IdEst__173876EA];
GO
IF OBJECT_ID(N'[dbo].[FK__RegistroA__IdSit__182C9B23]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroAnimal] DROP CONSTRAINT [FK__RegistroA__IdSit__182C9B23];
GO
IF OBJECT_ID(N'[dbo].[FK__RegistroA__IdTip__164452B1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroAnimal] DROP CONSTRAINT [FK__RegistroA__IdTip__164452B1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EstadoAnimal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoAnimal];
GO
IF OBJECT_ID(N'[dbo].[RegistroAnimal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegistroAnimal];
GO
IF OBJECT_ID(N'[dbo].[SituacaoAnimal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SituacaoAnimal];
GO
IF OBJECT_ID(N'[dbo].[TipoAnimal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoAnimal];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EstadoAnimal'
CREATE TABLE [dbo].[EstadoAnimal] (
    [IdEstadoAnimal] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(200)  NULL
);
GO

-- Creating table 'RegistroAnimal'
CREATE TABLE [dbo].[RegistroAnimal] (
    [IdRegistroAnimal] int IDENTITY(1,1) NOT NULL,
    [IdTipoAnimal] int  NOT NULL,
    [IdEstadoAnimal] int  NOT NULL,
    [IdSituacaoAnimal] int  NOT NULL,
    [Descricao] varchar(500)  NULL,
    [Latitude] decimal(10,7)  NOT NULL,
    [Longitude] decimal(10,7)  NOT NULL
);
GO

-- Creating table 'SituacaoAnimal'
CREATE TABLE [dbo].[SituacaoAnimal] (
    [IdSituacaoAnimal] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(200)  NULL
);
GO

-- Creating table 'TipoAnimal'
CREATE TABLE [dbo].[TipoAnimal] (
    [IdTipoAnimal] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(200)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdEstadoAnimal] in table 'EstadoAnimal'
ALTER TABLE [dbo].[EstadoAnimal]
ADD CONSTRAINT [PK_EstadoAnimal]
    PRIMARY KEY CLUSTERED ([IdEstadoAnimal] ASC);
GO

-- Creating primary key on [IdRegistroAnimal] in table 'RegistroAnimal'
ALTER TABLE [dbo].[RegistroAnimal]
ADD CONSTRAINT [PK_RegistroAnimal]
    PRIMARY KEY CLUSTERED ([IdRegistroAnimal] ASC);
GO

-- Creating primary key on [IdSituacaoAnimal] in table 'SituacaoAnimal'
ALTER TABLE [dbo].[SituacaoAnimal]
ADD CONSTRAINT [PK_SituacaoAnimal]
    PRIMARY KEY CLUSTERED ([IdSituacaoAnimal] ASC);
GO

-- Creating primary key on [IdTipoAnimal] in table 'TipoAnimal'
ALTER TABLE [dbo].[TipoAnimal]
ADD CONSTRAINT [PK_TipoAnimal]
    PRIMARY KEY CLUSTERED ([IdTipoAnimal] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEstadoAnimal] in table 'RegistroAnimal'
ALTER TABLE [dbo].[RegistroAnimal]
ADD CONSTRAINT [FK__RegistroA__IdEst__173876EA]
    FOREIGN KEY ([IdEstadoAnimal])
    REFERENCES [dbo].[EstadoAnimal]
        ([IdEstadoAnimal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RegistroA__IdEst__173876EA'
CREATE INDEX [IX_FK__RegistroA__IdEst__173876EA]
ON [dbo].[RegistroAnimal]
    ([IdEstadoAnimal]);
GO

-- Creating foreign key on [IdSituacaoAnimal] in table 'RegistroAnimal'
ALTER TABLE [dbo].[RegistroAnimal]
ADD CONSTRAINT [FK__RegistroA__IdSit__182C9B23]
    FOREIGN KEY ([IdSituacaoAnimal])
    REFERENCES [dbo].[SituacaoAnimal]
        ([IdSituacaoAnimal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RegistroA__IdSit__182C9B23'
CREATE INDEX [IX_FK__RegistroA__IdSit__182C9B23]
ON [dbo].[RegistroAnimal]
    ([IdSituacaoAnimal]);
GO

-- Creating foreign key on [IdTipoAnimal] in table 'RegistroAnimal'
ALTER TABLE [dbo].[RegistroAnimal]
ADD CONSTRAINT [FK__RegistroA__IdTip__164452B1]
    FOREIGN KEY ([IdTipoAnimal])
    REFERENCES [dbo].[TipoAnimal]
        ([IdTipoAnimal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RegistroA__IdTip__164452B1'
CREATE INDEX [IX_FK__RegistroA__IdTip__164452B1]
ON [dbo].[RegistroAnimal]
    ([IdTipoAnimal]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
USE [InventarioModulo6]
GO
/****** Object:  Table [dbo].[TEntradas]    Script Date: 04/10/2020 09:34:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEntradas](
	[EntradaID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoID] [int] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_TEntradas] PRIMARY KEY CLUSTERED 
(
	[EntradaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TProductos]    Script Date: 04/10/2020 09:34:25 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TProductos](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TProductos] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TEntradas]  WITH CHECK ADD  CONSTRAINT [FK_Entradas_TProductos] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[TProductos] ([ProductoID])
GO
ALTER TABLE [dbo].[TEntradas] CHECK CONSTRAINT [FK_Entradas_TProductos]
GO

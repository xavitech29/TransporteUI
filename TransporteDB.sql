USE [TransporteDB]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 6/2/2024 20:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[id_estudiante] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[cedula] [varchar](10) NULL,
	[direccion] [nvarchar](50) NULL,
	[email] [varchar](100) NULL,
	[celular] [varchar](10) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK__Estudian__9B410A89474E9E8F] PRIMARY KEY CLUSTERED 
(
	[id_estudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial]    Script Date: 6/2/2024 20:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial](
	[id_historial] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reserva] [datetime] NULL,
	[id_ruta] [int] NULL,
	[id_estudiante] [int] NULL,
 CONSTRAINT [PK__Historia__AAE1E4921BF03CA9] PRIMARY KEY CLUSTERED 
(
	[id_historial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 6/2/2024 20:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[id_estudiante] [int] NULL,
	[id_ruta] [int] NULL,
	[fecha_reserva] [datetime] NULL,
	[hora_reserva] [time](7) NULL,
	[estado] [bit] NULL,
	[id_vehiculo] [int] NULL,
 CONSTRAINT [PK__Reserva__12CAD9F462C90F63] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ruta]    Script Date: 6/2/2024 20:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ruta](
	[id_ruta] [int] IDENTITY(1,1) NOT NULL,
	[nombre_ruta] [nvarchar](100) NULL,
	[origen] [nvarchar](100) NULL,
	[destino] [nvarchar](100) NULL,
	[hora_salida] [time](7) NULL,
	[hora_llegada] [time](7) NULL,
	[fecha_ruta] [datetime] NULL,
	[capacidad] [nvarchar](50) NULL,
 CONSTRAINT [PK__Ruta__4851E68BF1A41305] PRIMARY KEY CLUSTERED 
(
	[id_ruta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 6/2/2024 20:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[id_vehiculo] [int] IDENTITY(1,1) NOT NULL,
	[placa] [varchar](20) NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[motor] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[anio] [int] NOT NULL,
	[chasis] [varchar](50) NOT NULL,
	[numero_pasajeros] [int] NOT NULL,
	[estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Estudiante] FOREIGN KEY([id_estudiante])
REFERENCES [dbo].[Estudiante] ([id_estudiante])
GO
ALTER TABLE [dbo].[Historial] CHECK CONSTRAINT [FK_Historial_Estudiante]
GO
ALTER TABLE [dbo].[Historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Ruta] FOREIGN KEY([id_ruta])
REFERENCES [dbo].[Ruta] ([id_ruta])
GO
ALTER TABLE [dbo].[Historial] CHECK CONSTRAINT [FK_Historial_Ruta]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Estudiante] FOREIGN KEY([id_estudiante])
REFERENCES [dbo].[Estudiante] ([id_estudiante])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Estudiante]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Vehiculo] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[Vehiculo] ([id_vehiculo])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Vehiculo]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Ruta] FOREIGN KEY([id_ruta])
REFERENCES [dbo].[Ruta] ([id_ruta])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Ruta]
GO

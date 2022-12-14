USE [registerstore]
GO
/****** Object:  Table [dbo].[existencias]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[existencias](
	[idproducto] [int] NOT NULL,
	[stock] [int] NOT NULL,
	[tienda] [varchar](15) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedidos]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedidos](
	[idpedido] [int] IDENTITY(1,1) NOT NULL,
	[idproveedor] [int] NOT NULL,
	[total] [int] NOT NULL,
	[subtotal] [int] NOT NULL,
	[fecha] [varchar](20) NOT NULL,
	[hora] [varchar](20) NOT NULL,
	[estado] [varchar](20) NOT NULL,
	[pago] [varchar](20) NOT NULL,
	[tienda] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](15) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[laboratorio] [varchar](20) NOT NULL,
	[presentacion] [varchar](15) NOT NULL,
	[cantidad] [varchar](15) NULL,
	[compra] [int] NULL,
	[venta] [int] NULL,
	[iva] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[idproveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[tipo] [varchar](15) NOT NULL,
	[empresa] [varchar](30) NOT NULL,
	[celular] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subpedidos]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subpedidos](
	[idpedido] [int] NOT NULL,
	[idproveedor] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[unidades] [int] NOT NULL,
	[compra] [int] NOT NULL,
	[descuento] [int] NOT NULL,
	[total] [int] NOT NULL,
	[subtotal] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subproveedores]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subproveedores](
	[idproveedor] [int] NOT NULL,
	[idproducto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subventas]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subventas](
	[idventa] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[unidades] [int] NOT NULL,
	[total] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
	[descuento] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tiendas]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tiendas](
	[idtienda] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[direccion] [varchar](30) NOT NULL,
	[telefono] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtienda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[direccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
	[clave] [varchar](15) NOT NULL,
	[tipo] [varchar](20) NOT NULL,
	[tienda] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 1/09/2022 1:51:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[idventa] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [varchar](20) NOT NULL,
	[hora] [varchar](20) NOT NULL,
	[total] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
	[descuento] [int] NULL,
	[abono] [int] NULL,
	[medio] [varchar](20) NOT NULL,
	[referencia] [varchar](20) NULL,
	[estado] [varchar](20) NOT NULL,
	[tienda] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

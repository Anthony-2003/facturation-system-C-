USE [Programa]
GO
/****** Object:  StoredProcedure [dbo].[DatosEmpleados]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DatosEmpleados]
AS
BEGIN
SELECT Empleados.ID_Empleado,Empleados.Nombre, Empleados.Apellido,Empleados.Teléfono, Empleados.Cédula, Departamento.Departamento, Empleados.Sexo, Empleados.Sueldo FROM Empleados
INNER JOIN Departamento ON Empleados.ID_Departamento = Departamento.ID_Departamento
END
GO
/****** Object:  StoredProcedure [dbo].[DatosProductos]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DatosProductos]
AS
BEGIN
SELECT Producto.ID_Producto, Producto.Nombre,Producto.Precio,Producto.Cantidad,Categoria.Categoria, Proveedor.Empresa FROM Producto
INNER JOIN Categoria ON Producto.ID_Categoria = Categoria.ID_Categoria INNER JOIN Proveedor ON Producto.ID_Proveedor = Proveedor.ID_Proveedor
END
GO
/****** Object:  StoredProcedure [dbo].[DatosProveedor]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DatosProveedor]
AS
BEGIN
SELECT Proveedor.ID_Proveedor, Proveedor.Nombre_Proveedor, Proveedor.Apellido_Proveedor, Proveedor.Empresa, Proveedor.Teléfono, Proveedor.Dirección FROM Proveedor
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarProductos]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertarProductos]
@NombreP varchar(100),
@Precio money,
@Cantidad int,
@Categoria int,
@Proveedor int
AS
INSERT INTO Producto VALUES( @NombreP,@Precio,@Cantidad,@Categoria,@Proveedor)
GO
/****** Object:  StoredProcedure [dbo].[MostrarProveedor]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarProveedor]
AS
BEGIN
SELECT * FROM Proveedor
END
GO
/****** Object:  StoredProcedure [dbo].[Prueba]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Prueba]
@Id AS INT
AS 
Select * from Clientes where ID_Cliente = @Id
GO
/****** Object:  StoredProcedure [dbo].[Prueba1]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Prueba1]
@IDP varchar (10)
AS 
Select * from Producto WHERE ID_Producto = @IDP
GO
/****** Object:  StoredProcedure [dbo].[Reporte_x_Ventas]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Reporte_x_Ventas]
(
@Desde date,
@Hasta date
)
AS
BEGIN
SELECT Factura.ID_Factura, Clientes.NombreC, Clientes.Apellido, Empleados.Nombre AS Empleado, Producto.Nombre AS Producto,Producto.Precio,Detalle_Factura.Cantidad_PF,Detalle_Factura.Total, Factura.Fecha_Compra
FROM Factura INNER JOIN Detalle_Factura ON Factura.ID_Factura = Detalle_Factura.ID_Factura INNER JOIN Producto ON Producto.ID_Producto = Detalle_Factura.ID_Producto INNER JOIN Clientes
ON Clientes.ID_Cliente = Factura.ID_Cliente inner join Empleados ON Empleados.ID_Empleado = Factura.ID_Empleado where Factura.Fecha_Compra between @Desde and @Hasta
END
GO
/****** Object:  StoredProcedure [dbo].[Reporte_x_Ventas_V2]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Reporte_x_Ventas_V2]
AS
BEGIN
SELECT Factura.ID_Factura,Clientes.ID_Cliente,Clientes.NombreC, Clientes.Apellido, Empleados.Nombre AS Empleado, Producto.Nombre AS Producto,Detalle_Factura.Precio_unitario,Detalle_Factura.Cantidad_PF,Detalle_Factura.Total, Factura.Fecha_Compra
FROM Factura INNER JOIN Detalle_Factura ON Factura.ID_Factura = Detalle_Factura.ID_Factura INNER JOIN Producto ON Producto.ID_Producto = Detalle_Factura.ID_Producto INNER JOIN Clientes
ON Clientes.ID_Cliente = Factura.ID_Cliente inner join Empleados ON Empleados.ID_Empleado = Factura.ID_Empleado 
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteCompras]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ReporteCompras]
AS
BEGIN
SELECT Compras.ID_Compra, Compras.Fecha_compra,Proveedor.Nombre_Proveedor AS Nombre, Proveedor.Apellido_Proveedor AS Apellido, Proveedor.Empresa AS Empresa, Producto.Nombre AS Productos,
Detalle_Compra.Cantidad_PDC AS Cantidad, Detalle_Compra.Precio, Detalle_Compra.Total FROM Compras inner join Detalle_Compra on Compras.ID_Compra = Detalle_Compra.ID_Compra 
inner join Proveedor ON Proveedor.ID_Proveedor = Compras.ID_Proveedor INNER JOIN Producto on Producto.ID_Producto = Detalle_Compra.ID_Producto
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteVentas]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ReporteVentas]
(
@Desde date,
@Hasta date
)
AS
BEGIN
SELECT Factura.ID_Factura, Clientes.NombreC, Clientes.Apellido, Empleados.Nombre AS Empleado, Producto.Nombre AS Producto,Producto.Precio,Detalle_Factura.Cantidad_PF,Detalle_Factura.Total, Factura.Fecha_Compra
FROM Factura INNER JOIN Detalle_Factura ON Factura.ID_Factura = Detalle_Factura.ID_Factura INNER JOIN Producto ON Producto.ID_Producto = Detalle_Factura.ID_Producto INNER JOIN Clientes
ON Clientes.ID_Cliente = Factura.ID_Cliente inner join Empleados ON Empleados.ID_Empleado = Factura.ID_Empleado where Factura.Fecha_Compra between @Desde and @Hasta
END
GO
/****** Object:  Table [dbo].[BK_ClientesEliminados]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BK_ClientesEliminados](
	[ID_Cliente] [int] NULL,
	[Nombre] [varchar](20) NULL,
	[Apellido] [varchar](20) NULL,
	[Telefono] [varchar](15) NULL,
	[Dirección] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [varchar](100) NULL,
 CONSTRAINT [PK__Categori__02AA07859E797237] PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreC] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Teléfono] [varchar](100) NULL,
	[Dirección] [varchar](100) NULL,
	[Estado] [varchar](15) NULL,
 CONSTRAINT [PK__Clientes__E005FBFFC66F75AC] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[ID_Compra] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_compra] [date] NULL,
	[ID_Proveedor] [int] NULL,
 CONSTRAINT [PK__Compras__A9D5994E1FC0E2E0] PRIMARY KEY CLUSTERED 
(
	[ID_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento](
	[ID_Departamento] [int] IDENTITY(1,1) NOT NULL,
	[Departamento] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_Compra]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Compra](
	[ID_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[ID_Compra] [int] NULL,
	[ID_Producto] [int] NULL,
	[Cantidad_PDC] [int] NULL,
	[Precio] [int] NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK__Detalle___B3E0CED38500FC08] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalle_Factura]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Factura](
	[ID_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[ID_Factura] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Cantidad_PF] [int] NULL,
	[Precio_unitario] [int] NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK__Detalle___B3E0CED32F1B06AE] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Teléfono] [varchar](14) NULL,
	[Cédula] [varchar](13) NULL,
	[ID_Departamento] [int] NULL,
	[Sexo] [char](1) NULL,
	[Sueldo] [int] NULL,
	[Estado] [varchar](13) NULL,
 CONSTRAINT [PK__Empleado__B7872C9052772DC7] PRIMARY KEY CLUSTERED 
(
	[ID_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[ID_Factura] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[ID_Empleado] [int] NOT NULL,
	[Fecha_Compra] [datetime] NULL,
 CONSTRAINT [PK__Factura__E9D586A8BD62CD6E] PRIMARY KEY CLUSTERED 
(
	[ID_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Cantidad] [int] NULL,
	[Precio] [int] NULL,
	[ID_Categoria] [int] NULL,
	[ID_Proveedor] [int] NULL,
	[Estado] [varchar](13) NULL,
 CONSTRAINT [PK__Producto__9B4120E21CE39C19] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Proveedor] [varchar](100) NULL,
	[Apellido_Proveedor] [varchar](100) NULL,
	[Empresa] [varchar](100) NULL,
	[Teléfono] [varchar](14) NULL,
	[Dirección] [varchar](50) NULL,
	[Estado] [varchar](13) NULL,
 CONSTRAINT [PK__Proveedo__7D65272FDA94296F] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 27/3/2020 2:56:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Tipo_Usuario] [varchar](50) NULL,
	[ID_Empleado] [int] NULL,
 CONSTRAINT [PK__Usuarios__DE4431C5EFFE5A84] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [Compras_ID_Proveedor] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedor] ([ID_Proveedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [Compras_ID_Proveedor]
GO
ALTER TABLE [dbo].[Detalle_Compra]  WITH CHECK ADD  CONSTRAINT [Detalle_Compra_ID_Compra] FOREIGN KEY([ID_Compra])
REFERENCES [dbo].[Compras] ([ID_Compra])
GO
ALTER TABLE [dbo].[Detalle_Compra] CHECK CONSTRAINT [Detalle_Compra_ID_Compra]
GO
ALTER TABLE [dbo].[Detalle_Compra]  WITH CHECK ADD  CONSTRAINT [FK_ID_Producto_Detalle_Compra] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[Detalle_Compra] CHECK CONSTRAINT [FK_ID_Producto_Detalle_Compra]
GO
ALTER TABLE [dbo].[Detalle_Factura]  WITH CHECK ADD  CONSTRAINT [Detalle_Factura_ID_Factura] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[Factura] ([ID_Factura])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalle_Factura] CHECK CONSTRAINT [Detalle_Factura_ID_Factura]
GO
ALTER TABLE [dbo].[Detalle_Factura]  WITH CHECK ADD  CONSTRAINT [Detalle_Factura_ID_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[Detalle_Factura] CHECK CONSTRAINT [Detalle_Factura_ID_Producto]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [Empleados_Departamento] FOREIGN KEY([ID_Departamento])
REFERENCES [dbo].[Departamento] ([ID_Departamento])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [Empleados_Departamento]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [Factura_ID_Cliente] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [Factura_ID_Cliente]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [Factura_ID_Empleado] FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[Empleados] ([ID_Empleado])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [Factura_ID_Empleado]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [PK_ID_Producto_Producto] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [PK_ID_Producto_Producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [PK_ID_Proveedor_Producto] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedor] ([ID_Proveedor])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [PK_ID_Proveedor_Producto]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [Usuarios_FK_ID_Empleado] FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[Empleados] ([ID_Empleado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [Usuarios_FK_ID_Empleado]
GO

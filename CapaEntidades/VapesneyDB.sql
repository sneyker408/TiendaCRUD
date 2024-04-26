-- Creación de la base de datos Vapesney
CREATE DATABASE Vapesney_BC;

-- Uso de la base de datos vapesney
USE Vapesney_BC;

-- Creación de la tabla de Categorías de Productos
CREATE TABLE CategoriasProductos (
    CategoriaID INT  PRIMARY KEY NOT NULL,
    NombreCategoria VARCHAR(100)
);

-- Creación de la tabla de Productos
CREATE TABLE Productos (
    ProductoID INT  PRIMARY KEY NOT NULL,
    NombreProducto VARCHAR(100),
    Descripcion TEXT,
    Precio DECIMAL(10, 2),
    StockDisponible INT,
    Fabricante VARCHAR(100),
    EstadoPedido VARCHAR(50),
    CategoriaID INT,
    FOREIGN KEY (CategoriaID) REFERENCES CategoriasProductos(CategoriaID)
);

-- Creación de la tabla de Clientes
CREATE TABLE Clientes (
    ClienteID INT  PRIMARY KEY NOT NULL,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    CorreoElectronico VARCHAR(100),
    Direccion VARCHAR(255),
    NumeroTelefono VARCHAR(20)
);

-- Creación de la tabla de Pedidos
CREATE TABLE Pedidos (
    PedidoID INT  PRIMARY KEY NOT NULL,
    ClienteID INT,
    FechaHoraPedido DATETIME,
    EstadoPedido VARCHAR(50),
    TotalPedido DECIMAL(10, 2),
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
);

-- Creación de la tabla de Detalles del Pedido
CREATE TABLE DetallesPedido (
    DetallePedidoID INT  PRIMARY KEY,
    PedidoID INT,
    ProductoID INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10, 2),
    FOREIGN KEY (PedidoID) REFERENCES Pedidos(PedidoID),
    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);

-- Creación de la tabla de Proveedores
CREATE TABLE Proveedores (
    ProveedorID INT  PRIMARY KEY NOT NULL,
    NombreProveedor VARCHAR(100),
    Direccion VARCHAR(255),
    CorreoElectronico VARCHAR(100),
    NumeroTelefono VARCHAR(20)
);

-- Creación de la tabla de Inventario
CREATE TABLE Inventario (
    InventarioID INT PRIMARY KEY NOT NULL,
    ProductoID INT,
    CantidadStock INT,
    FechaUltimaReposicion DATE,
    ProveedorID INT,
    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID),
    FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID)
);

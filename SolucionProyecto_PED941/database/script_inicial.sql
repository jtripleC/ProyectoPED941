-- Crear base de datos
CREATE DATABASE InventarioPapeleriaPED;
GO

USE InventarioPapeleriaPED;
GO

-- ============================
-- Tabla: Productos
-- ============================
CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(50) NOT NULL UNIQUE,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL DEFAULT 0,
    StockMinimo INT NOT NULL DEFAULT 0
);
GO

-- ============================
-- Tabla: Movimientos
-- ============================
CREATE TABLE Movimientos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductoId INT NOT NULL,
    TipoMovimiento VARCHAR(20) NOT NULL, -- Entrada / Salida
    Cantidad INT NOT NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Movimientos_Productos 
    FOREIGN KEY (ProductoId) REFERENCES Productos(Id)
);
GO

-- ============================
-- Datos de prueba (opcional)
-- ============================

INSERT INTO Productos (Codigo, Nombre, Precio, Stock, StockMinimo)
VALUES 
('P001', 'Cuaderno', 2.50, 20, 5),
('P002', 'Lapicero', 0.50, 50, 10),
('P003', 'Borrador', 0.30, 15, 5);
GO
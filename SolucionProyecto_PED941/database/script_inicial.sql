
-- =========================================
-- CREAR BASE DE DATOS
-- =========================================
CREATE DATABASE InventarioPapeleriaPED;
GO

USE InventarioPapeleriaPED;
GO

-- =========================================
-- TABLA: Productos
-- =========================================
CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(50) NOT NULL UNIQUE,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL DEFAULT 0,
    StockMinimo INT NOT NULL DEFAULT 0
);
GO

-- =========================================
-- TABLA: Movimientos
-- =========================================
CREATE TABLE Movimientos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductoId INT NOT NULL,
    TipoMovimiento VARCHAR(20) NOT NULL,
    Cantidad INT NOT NULL,
    StockAnterior INT NOT NULL DEFAULT 0,
    StockResultante INT NOT NULL DEFAULT 0,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Movimientos_Productos
    FOREIGN KEY (ProductoId) REFERENCES Productos(Id)
);
GO

-- =========================================
-- INSERTAR PRODUCTOS
-- =========================================

SET IDENTITY_INSERT Productos ON;

INSERT INTO Productos
(Id, Codigo, Nombre, Precio, Stock, StockMinimo)
VALUES
(1, 'P001', 'Caja de Colores', 2.50, 20, 5),
(2, 'P002', 'Lapicero', 0.50, 10, 10),
(4, 'P004', 'Regla 30cm', 1.25, 2, 5),
(5, 'P005', 'Caja de Colores', 3.75, 0, 4),
(6, 'P006', 'Marcador Permanente', 1.10, 40, 8),
(7, 'P007', 'Tijera Escolar', 2.50, 12, 3),
(8, 'P008', 'Pegamento en Barra', 0.85, 30, 6),
(9, 'P009', 'Resaltador Amarillo', 0.95, 22, 5),
(10, 'P010', 'Folder Manila', 0.40, 50, 15),
(11, 'P011', 'Sacapuntas', 0.55, 35, 7),
(12, 'P012', 'Calculadora Cientifica', 15.99, 10, 2),
(13, 'P013', 'Papel Bond Carta', 6.50, 14, 4),
(14, 'P014', 'Crayones', 2.20, 20, 5),
(15, 'P015', 'Corrector Liquido', 1.35, 16, 4),
(34, 'P017', 'Sacabocados', 5.00, 15, 5),
(38, 'P016', 'Libreta Espiral', 3.10, 28, 6);

SET IDENTITY_INSERT Productos OFF;
GO

-- =========================================
-- INSERTAR MOVIMIENTOS
-- =========================================

SET IDENTITY_INSERT Movimientos ON;

INSERT INTO Movimientos
(Id, ProductoId, TipoMovimiento, Cantidad, StockAnterior, StockResultante, Fecha)
VALUES
(3, 2, 'SALIDA', 10, 50, 40, '2026-05-27 22:27:21'),
(5, 1, 'ENTRADA', 50, 20, 70, '2026-05-27 23:46:51'),
(7, 1, 'ENTRADA', 10, 0, 0, '2026-05-28 00:24:31'),
(8, 2, 'SALIDA', 5, 0, 0, '2026-05-28 00:24:31'),
(10, 4, 'SALIDA', 2, 0, 0, '2026-05-28 00:24:31'),
(11, 5, 'ENTRADA', 15, 0, 0, '2026-05-28 00:24:31'),
(12, 6, 'SALIDA', 4, 0, 0, '2026-05-28 00:24:31'),
(13, 7, 'ENTRADA', 6, 0, 0, '2026-05-28 00:24:31'),
(14, 8, 'SALIDA', 3, 0, 0, '2026-05-28 00:24:31'),
(15, 9, 'ENTRADA', 12, 0, 0, '2026-05-28 00:24:31'),
(16, 10, 'SALIDA', 7, 0, 0, '2026-05-28 00:24:31'),
(17, 11, 'ENTRADA', 9, 0, 0, '2026-05-28 00:24:31'),
(18, 12, 'SALIDA', 1, 0, 0, '2026-05-28 00:24:31'),
(19, 13, 'ENTRADA', 5, 0, 0, '2026-05-28 00:24:31'),
(20, 14, 'SALIDA', 2, 0, 0, '2026-05-28 00:24:31'),
(21, 15, 'ENTRADA', 11, 0, 0, '2026-05-28 00:24:31'),
(25, 4, 'SALIDA', 23, 25, 2, '2026-05-28 01:01:58'),
(27, 5, 'SALIDA', 18, 18, 0, '2026-05-28 01:02:40'),
(28, 10, 'SALIDA', 60, 60, 0, '2026-05-28 01:03:00'),
(29, 2, 'SALIDA', 30, 40, 10, '2026-05-28 01:23:22'),
(30, 10, 'ENTRADA', 50, 0, 50, '2026-05-28 18:26:07'),
(32, 1, 'SALIDA', 50, 70, 20, '2026-05-28 18:27:28');

SET IDENTITY_INSERT Movimientos OFF;
GO


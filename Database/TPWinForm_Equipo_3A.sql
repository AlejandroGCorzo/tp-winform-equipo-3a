IF DB_ID('TPWinForm_Equipo_3A') IS NULL
BEGIN
    CREATE DATABASE TPWinForm_Equipo_3A;
END
GO

USE TPWinForm_Equipo_3A;
GO

/* =========================
   CREACION TABLAS
========================= */

IF OBJECT_ID('ImagenesArticulo', 'U') IS NULL
BEGIN
    CREATE TABLE ImagenesArticulo (
        Id INT PRIMARY KEY IDENTITY(1,1),
        IdArticulo INT NOT NULL,
        UrlImagen VARCHAR(500) NOT NULL
    );
END
GO

IF OBJECT_ID('Articulos', 'U') IS NULL
BEGIN
    CREATE TABLE Articulos (
        Id INT PRIMARY KEY IDENTITY(1,1),
        Codigo VARCHAR(50) NOT NULL,
        Nombre VARCHAR(150) NOT NULL,
        Descripcion VARCHAR(500),
        IdMarca INT NOT NULL,
        IdCategoria INT NOT NULL,
        Precio DECIMAL(18,2) NOT NULL
    );
END
GO

IF OBJECT_ID('Marcas', 'U') IS NULL
BEGIN
    CREATE TABLE Marcas (
        Id INT PRIMARY KEY IDENTITY(1,1),
        Nombre VARCHAR(100) NOT NULL
    );
END
GO

IF OBJECT_ID('Categorias', 'U') IS NULL
BEGIN
    CREATE TABLE Categorias (
        Id INT PRIMARY KEY IDENTITY(1,1),
        Nombre VARCHAR(100) NOT NULL
    );
END
GO

/* =========================
   FOREIGN KEYS
========================= */

IF NOT EXISTS (
    SELECT * FROM sys.foreign_keys
    WHERE name = 'FK_Articulos_Marcas'
)
BEGIN
    ALTER TABLE Articulos
    ADD CONSTRAINT FK_Articulos_Marcas
    FOREIGN KEY (IdMarca) REFERENCES Marcas(Id);
END
GO

IF NOT EXISTS (
    SELECT * FROM sys.foreign_keys
    WHERE name = 'FK_Articulos_Categorias'
)
BEGIN
    ALTER TABLE Articulos
    ADD CONSTRAINT FK_Articulos_Categorias
    FOREIGN KEY (IdCategoria) REFERENCES Categorias(Id);
END
GO

IF NOT EXISTS (
    SELECT * FROM sys.foreign_keys
    WHERE name = 'FK_ImagenesArticulo_Articulos'
)
BEGIN
    ALTER TABLE ImagenesArticulo
    ADD CONSTRAINT FK_ImagenesArticulo_Articulos
    FOREIGN KEY (IdArticulo) REFERENCES Articulos(Id);
END
GO

/* =========================
   LIMPIEZA TOTAL
========================= */

DELETE FROM ImagenesArticulo;
DELETE FROM Articulos;
DELETE FROM Marcas;
DELETE FROM Categorias;
GO

DBCC CHECKIDENT ('ImagenesArticulo', RESEED, 0);
DBCC CHECKIDENT ('Articulos', RESEED, 0);
DBCC CHECKIDENT ('Marcas', RESEED, 0);
DBCC CHECKIDENT ('Categorias', RESEED, 0);
GO

/* =========================
   MARCAS
========================= */

INSERT INTO Marcas (Nombre)
VALUES
('Samsung'),
('Apple'),
('Xiaomi'),
('Nike'),
('Adidas'),
('Puma');
GO

/* =========================
   CATEGORIAS
========================= */

INSERT INTO Categorias (Nombre)
VALUES
('Celulares'),
('Calzado');
GO

/* =========================
   ARTICULOS
========================= */

INSERT INTO Articulos
(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
VALUES

('CEL001','Samsung Galaxy S24 Ultra','512GB Negro',1,1,1899999),
('CEL002','iPhone 15','128GB Blue',2,1,1499999),
('CEL003','Xiaomi Redmi Note 13','256GB Black',3,1,549999),
('CEL004','Samsung Galaxy A55','256GB',1,1,799999),
('CEL005','iPhone 14','128GB Midnight',2,1,1199999),
('CEL006','POCO X6 Pro','256GB',3,1,749999),
('CEL007','Galaxy S23 FE','256GB',1,1,999999),
('CEL008','iPhone SE','64GB',2,1,699999),
('CEL009','Xiaomi 14','512GB',3,1,1299999),
('CEL010','Galaxy Z Flip5','512GB',1,1,1599999),

('CAL001','Nike Air Max 270','Running urbana',4,2,249999),
('CAL002','Adidas Ultraboost','Running premium',5,2,289999),
('CAL003','Puma RS-X','Urbana',6,2,219999),
('CAL004','Nike Court Vision','Clasica',4,2,179999),
('CAL005','Adidas Superstar','Iconica',5,2,199999),
('CAL006','Puma Suede Classic','Retro',6,2,189999),
('CAL007','Nike Pegasus 40','Running',4,2,259999),
('CAL008','Adidas Forum Low','Streetwear',5,2,229999),
('CAL009','Puma Future Rider','Casual',6,2,209999),
('CAL010','Nike Dunk Low','Moda urbana',4,2,279999);
GO

/* =========================
   IMAGENES
========================= */

INSERT INTO ImagenesArticulo
(IdArticulo, UrlImagen)
VALUES
(1,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),
(2,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),
(3,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),
(4,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),
(5,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),
(6,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),
(7,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),
(8,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),
(9,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),
(10,'https://thumbs.dreamstime.com/b/tel%C3%A9fono-m%C3%B3vil-elegante-de-la-c%C3%A9lula-gen%C3%A9rica-del-110908669.jpg'),

(11,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg'),
(12,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg'),
(13,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg'),
(14,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg'),
(15,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg'),
(16,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg'),
(17,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg'),
(18,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg'),
(19,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg'),
(20,'https://thumbs.dreamstime.com/b/un-par-de-zapatillas-de-deporte-gen%C3%A9ricas-3882729.jpg');
GO
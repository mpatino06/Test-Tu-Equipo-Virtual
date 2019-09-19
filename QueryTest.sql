--PRUEBA TECNICA MIGUEL PATIÑO

GO
 
CREATE DATABASE PRUEBATECNICA


GO
USE PRUEBATECNICA

CREATE TABLE dbo.CLIENTES (COD_CLIENTE int NOT NULL
                      ,NOM_CLIENTE NVARCHAR(250)
					  ,CP_CLIENTE NUMERIC
					  ,LOC_CLIENTE NVARCHAR(50))

CREATE TABLE dbo.VENTAS (COD_CLIENTE int NOT NULL
                    ,IMPORTE DECIMAL(18,2))


INSERT INTO CLIENTES 
VALUES (1,'Construcciones ADA',  '28001', 'Madrid'), 
       (2,'Transportes Laborda', '41001', 'Sevilla') ,
       (3,'Tintorería Rápida',   '17001', 'Lugo'), 
       (4,'Grandes Almacenes',   '50001', 'Zaragoza') ,
       (5,'Diario de Navarra',   '26356', 'Barcelona'), 
       (6,'Arión Grupo',         '41562', 'Sevilla'),
	   (7,'Banco de Finanzas',   '28500', 'Madrid'),
	   (8,'Seguros TRI',         '41200', 'Madrid'),
	   (9,'Mudanzas Bello',      '15852', 'Barcelona') 

INSERT INTO VENTAS (COD_CLIENTE, IMPORTE)
VALUES (4, 406.78),
       (5, 807.84),
	   (6, 27.95),
	   (8, 666.28),
	   (9, 768.17)

--1.- Seleccionar todos los clientes ordenados por nombre del cliente
SELECT * FROM CLIENTES ORDER BY NOM_CLIENTE

--2.- Seleccionar los clientes cuya localidad sea Madrid
SELECT * FROM CLIENTES WHERE LOC_CLIENTE = 'Madrid'

--3.- Seleccionar todos los clientes cuyo código postal pertenezca a la provincia de Sevilla (los que comienzan por 41)
SELECT * FROM CLIENTES WHERE CP_CLIENTE LIKE '41%' AND LOC_CLIENTE <> 'Madrid'

--4. Seleccionar todos los clientes cuyo cósigo sea inferior a 10 o cuyo nombre de cliente comience por la letra A
SELECT * FROM CLIENTES where COD_CLIENTE < 10 AND NOM_CLIENTE LIKE 'A%'

--5. Contar cuántos clientes existen por cada localidad
SELECT COUNT(LOC_CLIENTE) AS CANT_CLIENTES, LOC_CLIENTE FROM CLIENTES GROUP BY LOC_CLIENTE

--6. Borrar los clientes cuyo nombre comience por la letra Z y termine por la letra z
DELETE FROM CLIENTES WHERE NOM_CLIENTE LIKE 'Z%Z' 

--7. Modificar el valor del código postal de los clientes cuya localidad sea Madrid con el valor 28001
UPDATE CLIENTES 
       SET CP_CLIENTE = '28001'
	WHERE LOC_CLIENTE = 'Madrid'

--8. Seleccionar los clientes cuyo importe de sus VENTAS sea distinto de cero.
SELECT *
FROM CLIENTES C
JOIN VENTAS V ON C.COD_CLIENTE = V.COD_CLIENTE 
WHERE V.IMPORTE <> 0

--9. Seleccionar todos los clientes junto con el importe de las ventas de cada uno.
SELECT C.COD_CLIENTE, C.NOM_CLIENTE, C.CP_CLIENTE, C.LOC_CLIENTE, ISNULL(V.IMPORTE, 0) AS IMPORTE
 FROM CLIENTES C
     LEFT JOIN VENTAS V ON C.COD_CLIENTE = V.COD_CLIENTE
ORDER BY 5 DESC

--10.  Modificar el importe de las ventas de los clientes a cero para aquellos clientes cuyo nombre contenga al menos una letra A.
UPDATE VENTAS
 SET IMPORTE = 0
WHERE COD_CLIENTE IN (SELECT COD_CLIENTE FROM CLIENTES WHERE NOM_CLIENTE LIKE '%A%')


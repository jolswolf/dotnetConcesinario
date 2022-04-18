create procedure getCochesPorTaller
@TallerSel int
AS
BEGIN
	SELECT Tallers.ID , Tallers.fecha_entrada, Tallers.fecha_salida, Coches.matricula, Coches.modelo, Marcas.nomMarca FROM TallerCoches 
	JOIN Coches 
	ON Coches.ID = TallerCoches.Coche_ID 
	JOIN Marcas
	ON Marcas.ID = Coches.ID
	JOIN Tallers
	ON Tallers.ID = TallerCoches.Taller_ID
	WHERE Tallers.ID = @TallerSel
END

EXEC getCochesPorTaller 2;
GO
USE BaseDispash
GO

CREATE PROCEDURE Select_DispUti
@FechaInicio DateTime, @FechaFinal DateTime
AS
SELECT [DispoEquipos].FechaHora, [DispoEquipos].Equipo, [DispoEquipos].Disponibilidad, [DispoEquipos].Utilizacion
FROM DispoEquipos
WHERE FechaHora >= @FechaInicio AND FechaHora <= @FechaFinal
ORDER BY FechaHora, Equipo
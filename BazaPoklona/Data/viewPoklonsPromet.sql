SELECT max(dbo.Poklon.Naziv) as NazivRobe, max(dbo.VrstaRobe.Naziv) AS VrstaRobe, sum(Cijena) AS UkupnoLovePoVrstiRobe FROM dbo.Poklon
JOIN dbo.VrstaRobe ON dbo.Poklon.VrstaRobe = dbo.VrstaRobe.Id
 GROUP BY VrstaRobe
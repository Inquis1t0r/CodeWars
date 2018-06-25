--but on the land of Lórien no shadow lay--
SELECT INITCAP(Elves.firstname) || ' ' || INITCAP(Elves.lastname) AS shortlist FROM Elves WHERE Elves.firstname LIKE '%tegil%' OR Elves.lastname LIKE '%astar%'; 

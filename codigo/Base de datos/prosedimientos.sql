-- Editar producto
Delimiter $$
create procedure
EditarProducto(IN codi Varchar(11), IN nombreP varchar(70), IN marc varchar(70),IN catego varchar(10),IN prec double,in canti INT,IN cs varchar(150))
begin
UPDATE `speekbik`.`productos`
SET
`codigo`= codi,
`nombre`= nombreP ,
`marca` = marc,
`categoria` =catego,
`precio` = prec,
`cantiadad`= canti,
`color_sabors`= cs
WHERE `codigo` = codi;
END$$
DELIMITER ;


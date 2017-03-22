
INSERT INTO `speekbik`.`categorias`
(`id`,
`nombre`)
VALUES
(1,'Nutricion'),(2,'Refaccione y accesorios');

INSERT INTO `speekbik`.`productos`
(`codigo`,
`nombre`,
`marca`,
`categoria`,
`precio`,
`cantidad`,
`color_sabor`)
VALUES
 ( '1','Gel Gu','M',1,35,70,'orange'),
    ('2','Gel Gu','M',1,35,8,'blackberry'),
	('3','Gel Gu','M',1,35,5,'chocolate'),
	('4','Gel Gu','M',1,35,7,'espresso love'),
	('5','Gel racers','M',1,25,18,'mora coco'),
	('6','Gel roctane','M',1,48,8,'choco coco nut'),
	('7','Gel roctane','M',1,48,11,'blueberry'),
	('8','Gel roctane','M',1,48,8,'pinapple'),
	('9','Gel roctane','M',1,48,9,'Lomonade'),
	('10','Gel roctane','M',1,48,12,'strawberry'),
	('11','Gomas chews','M',1,32,7,''),	
	('12','Sport beam extream','M',1,35,13,'cherry'),
	('13','Sport beam extream','M',1,35,7,'pomegranot'),
	('14','Strop wafel','M',1,36,13,'chocolate'),
	('15','Strop wafel','M',1,36,15,'wild berry'),
	('16','Tasa centro telescopio semi int 1 1/8','M',2,110,3,''),	
	('17','Balatas  shim xt','M',2,230,3,''),	
	('18','Balatas alonga shim deo','M',2,120,4,''),	
	('19','Balatas avid BB5','M',2,120,1,''),	
	('20','Balatas avid BB7','M',2,120,3,''),	
	('21','Balatas avid code','M',2,120,2,''),	
	('22','Balatas redonda ec','M',2,65,4,''),	
	('23','Balatas tektro','M',2,145,2,''),	
	('24','Bolsas de herramienta eco','E',2,45,6,''),	
	('25','Mazas eco del 36','E',2,30,2,''),	
	('26','Mazas eco tras 36','E',2,40,3,''),	
	('27','Mazas shim dico 32 tornillo','M',2,510,1,''),	
	('28','Mazas shim dico 36 center','M',2,510,1,''),	
	('29','Parches coldpach','E',2,25,8,''),	
	('30','Parches vermas 48','E',2,20,11,''),	
	('31','Tasa centro telescopio 1  1/8 a head','E',2,95,2,''),	
	('32','Tasa centro telescopio 1 11/8 standar','E',2,85,4,''),	
	('33','Tasa centro telescopio american neco','E',2,30,7,''),	
	('34','Tasa centro telescopio integr 1 1/2','M',2,480,2,''),	
	('35','Tasa centro telescopio integr 1 1/8','M',2,170,3,''),	
	('36','Tasas centro american neco','E',2,45,3,''),	
	('37','Tasas centro estándar neco','E',2,25,5,''),	
	('38','casco altrego eco','E',2,240,2,'amarillo'),
	('39','casco altrego eco','E',2,240,2,'rojo'),
	('40','casco altrego eco','E',2,240,2,'amarillo'),
	('41','casco altrego eco','E',2,240,2,'Rojo'),
	('42','casco scott ARX','M',2,1450,1,'negor'),
	('43','casco scott ARX','M',2,1450,1,'negor'),
	('44','casco scott ARX PLUS','M',2,1400,1,'naranja'),
	('45','casco scott ARX PLUS','M',2,1400,1,'naranja'),
	('46','casco urge allmo s/m','M',2,1500,1,'rojo'),
	('47','casco urge allmo s/m','M',2,1500,1,'rojo'),
	('48','protector cuadro eco','E',2,80,18,''),	
	('49','protector scott aspect','M',2,270,1,''),	
	('50','protector scott scale','M',2,300,1,''),	
	('51','sella milk	1 litro','M',2,50,9,''),	
	('52','sella milk	250 ml','M',2,150,11,''),	
	('53','sella milk	125 ml','M',2,120,12,''),	
	('54','sella milk	1 litro','M',2,50,9,''),	
	('56','sella milk	250 ml','M',2,150,11,''),	
('57','sella milk	125 ml','M',2,120,12,'')	;

INSERT INTO `speekbik`.`usuarios`
(`idUsuario`,
`nombre`,
`pass`)
VALUES
('001','admin','1234');



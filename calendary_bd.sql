CREATE DATABASE calendary_bd;
USE calendary_bd;

CREATE TABLE usuario(
	id INT IDENTITY(1,1),
    usser VARCHAR (20),
	pass VARCHAR(20),
	primary key(id)
);

SELECT *
FROM usuario where usser = 'berny'

insert into usuario values ('maria',12345);

CREATE TABLE fichaPeriodoInicio(
	id INT IDENTITY(1,1),
    fechaUltimo date,
	duracionCiclo int,
    duracionPeriodo int,
    primary key(id)
);

CREATE TABLE registro(
	id INT IDENTITY(1,1),
    inicio bit,
    termino bit,
    observacion varchar(1000),
    metodoAnticonceptivo bit,
    actoSexual bit,
    
    /*Estado de ánimo*/
    agotada bit,
    ansiosa bit,
    coqueta bit,
    deprimida bit,
    enojada bit,
    nauseas bit,
    libidinosa bit,
    estres bit,
    irritable bit,
    insomnio bit,
    rara bit,
    sensible bit,
    
    /*Síntomas*/
    dolorCabeza bit,
    migraña bit,
    dolorPechos bit,
    sensibilidadPechos bit,
    dolorEspalda bit,
    dolorLumbar bit,
    calambre bit,
    escalosfrios bit,
    sarpullido bit,
    sofoco bit,
    dolorPelvis bit,
    hinchazon bit,
    estreñimiento bit,
    diarrea bit,
    antojos bit,
    dolorPorOvulacion bit,
    sangrado bit,
    manchado bit,
    
    /*Fluidos*/
    seco bit,
    pegajoso bit,
    cremoso bit,
    verde bit,
    conSangre bit,
    conMalOlor bit,
    primary key(id)
);

create table tips(
	id int IDENTITY(1,1),
	descripcion varchar(1000),
	primary key(id)
);

insert into tips values ('Los días fértiles se presentan aproximadamente a la mitad del ciclo menstrual');
insert into tips values ('Saber si tu ciclo menstrual es regular o irregular también influirá de forma notable para calcular tus días fértiles');
insert into tips values ('El embarazo se consigue cuando se produce la ovulación y se tienen relaciones sexuales en el periodo preovulatorio');
insert into tips values ('Aunque la mujer tenga relaciones sexuales normales durante el periodo de ovulacion, solo existe un 25% de posibilidades de quedar embarazada');
insert into tips values ('La ovulación suele ocurrir aproximadamente 14 días después del primer día de menstruación');
insert into tips values ('La copa menstrual es un recipiente que se inserta en la vagina durante la menstruación para depositar el flujo menstrual. A diferencia de los tampones, que también se usan internamente, la copa menstrual no absorbe la sangre. Más bien, se queda contenida en el interior de la copa hasta que se extrae de la vagina y se desecha el líquido');
insert into tips values ('Un tampón es un artículo de higiene femenina, para absorber el flujo de la menstruación');
insert into tips values ('En los países donde la virginidad es sinónimo de reputación femenina, es frecuente preguntar si los tampones para la menstruación pueden romper el himen de la mujer. Es prácticamente imposible que un tampón rompa el himen, porque éste tiene una apertura que es por donde baja el flujo menstrual, y es justo allí por donde se introduce el tampón');
insert into tips values ('La menstruación es un proceso cíclico y fisiológico de las mujeres sexualmente maduras que ocurre con una cadencia media aproximada de veintiocho días, aunque el 90% por ciento de las mujeres tienen ciclos de entre 24 y 36 días');
insert into tips values ('La menstruación forma parte del ciclo sexual femenino, el cual prepara el cuerpo de la mujer para el embarazo cada mes');
insert into tips values ('La ausencia de menstruación es un síntoma importante y se llama amenorrea');
insert into tips values ('Los óvulos son las células sexuales o gametos femeninos.​Son células grandes, esféricas e inmóviles. Desde la pubertad, cada 28 días aproximadamente, madura un ovocito en uno de los ovarios y pasa a una de las trompas de falopio, durante el denominado ciclo menstrual, este cuando se fecunda por un espermatozoide se convierte en un cigoto');







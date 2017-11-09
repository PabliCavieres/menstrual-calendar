CREATE DATABASE calendary_bd;
USE calendary_bd;

CREATE TABLE usuario(
	id INT AUTO_INCREMENT,
    user varchar(20),
    pass varchar(8),
    primary key (id)
);

CREATE TABLE fichaPeriodoInicio(
	id INT AUTO_INCREMENT,
    fechaUltimo date,
	duracionCiclo int,
    duracionPeriodo int,
    primary key(id)
);

CREATE TABLE registro(
	id INT AUTO_INCREMENT,
    inicio bool,
    termino bool,
    observacion varchar(1000),
    metodoAnticonceptivo bool,
    actoSexual bool,
    
    /*Estado de ánimo*/
    agotada bool,
    ansiosa bool,
    coqueta bool,
    deprimida bool,
    enojada bool,
    nauseas bool,
    libidinosa bool,
    estres bool,
    irritable bool,
    insomnio bool,
    rara bool,
    sensible bool,
    
    /*Síntomas*/
    dolorCabeza bool,
    migraña bool,
    dolorPechos bool,
    sensibilidadPechos bool,
    dolorEspalda bool,
    dolorLumbar bool,
    calambre bool,
    escalosfrios bool,
    sarpullido bool,
    sofoco bool,
    dolorPelvis bool,
    hinchazon bool,
    estreñimiento bool,
    diarrea bool,
    antojos bool,
    dolorPorOvulacion bool,
    sangrado bool,
    manchado bool,
    
    /*Fluidos*/
    seco bool,
    pegajoso bool,
    cremoso bool,
    verde bool,
    conSangre bool,
    conMalOlor bool,
    primary key(id)
);


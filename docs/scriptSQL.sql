

-- SCRIPT SQL v3.1.1 - parkDB
-- ACTUALIZADO: 12 MARZO 2021

CREATE TABLE vehiculos
(
    placa VARCHAR(10) PRIMARY KEY,
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    color VARCHAR(25) NOT NULL
);

CREATE TABLE estacionamientos
(
    id_estacionamiento BIGSERIAL PRIMARY KEY,
    nombre_estacionamiento VARCHAR(100) NOT NULL,
    direccion_estacionamiento VARCHAR(200) NOT NULL,
    telefono_estacionamiento VARCHAR(20) NOT NULL,
    lugares_totales INTEGER NOT NULL,
    lugares_ocupados INTEGER NOT NULL,
    precio_normal DECIMAL NOT NULL,
    precio_pension DECIMAL NOT NULL
);

CREATE TABLE usuarios
(
    usuario VARCHAR(20) PRIMARY KEY,
    contraseña VARCHAR(20) NOT NULL,
    nombres VARCHAR(50) NOT NULL,
    apellidos VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    puesto VARCHAR(100) NOT NULL,
    salario DECIMAL NOT NULL,
    administrador BOOLEAN NOT NULL,
    avatar VARCHAR(200)
);

CREATE TABLE tickets
(
    id_ticket BIGSERIAL PRIMARY KEY,
    id_estacionamiento SERIAL REFERENCES estacionamientos (id_estacionamiento) ON DELETE CASCADE,
    placa VARCHAR(10) REFERENCES vehiculos (placa) ON UPDATE CASCADE ON DELETE CASCADE,
    fecha_entrada TIMESTAMP
    WITHOUT TIME ZONE NOT NULL,
        modo_pension BOOLEAN NOT NULL,
        validado BOOLEAN NOT NULL
    );

CREATE TABLE trabajan_en
(
    id_estacionamiento SERIAL REFERENCES estacionamientos (id_estacionamiento) ON DELETE CASCADE,
    usuario VARCHAR(20) REFERENCES usuarios (usuario) ON UPDATE CASCADE ON DELETE CASCADE
);


INSERT INTO usuarios VALUES ('user', 'pass', 'John', 'Doe', 'john@mail.com', 'GERENTE', 15000, true, '');
INSERT INTO estacionamientos VALUES (DEFAULT, 'MULBAR', 'Calle Francisco I. Madero 188, Zona Centro, 44100 Guadalajara, Jal', '3334067600', 5, 0, 20, 17);
INSERT INTO trabajan_en VALUES (1, 'user');

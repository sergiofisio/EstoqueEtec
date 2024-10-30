show databases;

use dbestoque;

show tables;

CREATE TABLE IF NOT EXISTS products (
    cod INT AUTO_INCREMENT PRIMARY KEY,
    description VARCHAR(50) NOT NULL,
    value DECIMAL(10,2) NOT NULL,
    expiration_date TIMESTAMP NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS movto (
    cod_mov INT AUTO_INCREMENT PRIMARY KEY,
    cod_prod INT NOT NULL,
    movto_date TIMESTAMP NOT NULL,
    movto_type ENUM('entrada', 'saida') NOT NULL,
    qty INT NOT NULL CHECK (qty > 0),
    info VARCHAR(255), 
    FOREIGN KEY (cod_prod) REFERENCES products(cod),
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

insert into products 
	(cod, description, value, expiration_date) 
	values
    (1, "refirgerante zero", 10.59, "2025-12-27"),
    (2, "refirgerante cola", 10.00, "2025-12-27"),
    (3, "suco de laranja", 8.90, "2030-12-31");

select * from movto;

SELECT cod as CODIGO, description as DESCRICAO, value as VALOR, DATE_FORMAT(expiration_date, '%d/%m/%Y') as VALIDADE 
FROM products;

SELECT cod as CODIGO, description as DESCRICAO, value as VALOR, DATE_FORMAT(expiration_date, '%d/%m/%Y') as VALIDADE 
FROM products
WHERE cod = 1;

SELECT cod_mov, cod_prod, movto_date, movto_type, qty, info 
FROM movto
WHERE cod_mov = 1;

UPDATE movto
SET 
    cod_prod = 3,
    movto_date = '2024-10-30',
    movto_type = 'entrada',
    qty = 4,
    info = 'natural'
WHERE cod_mov = 1;

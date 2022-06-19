DROP DATABASE if exists cinema;
create database if not exists cinema;
use cinema;

CREATE TABLE cliente (
cpf VARCHAR(11) PRIMARY KEY,
nome VARCHAR(45) NOT NULL,
dataNascimento DATE NOT NULL,
email VARCHAR(100) NOT NULL,
senha VARCHAR(45) NOT NULL 
);

CREATE TABLE filme (
idFilme INT AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR(45) NOT NULL,
genero VARCHAR(45) NOT NULL,
lancamento DATE NOT NULL,
duracao TIME NOT NULL,
classificacao enum ('Livre','10 anos','12 anos','14 anos','16 anos','18 anos')
);

CREATE TABLE sala (
numeroSala INT PRIMARY KEY,
qtdAssentos INT NOT NULL
);

CREATE TABLE ticket (
idTicket INT AUTO_INCREMENT PRIMARY KEY,
cpfCliente varchar(11),
idFilme INT,
numeroSala INT,
preco DECIMAL(5,2) NULL DEFAULT 0.00,
dataHora DATETIME NOT NULL,
assento varchar(4) NOT NULL,
versao3d BOOL NULL DEFAULT 0,
legendado BOOL NULL DEFAULT 0,
meiaEntrada BOOL NULL DEFAULT 0,

FOREIGN KEY (cpfCliente) REFERENCES cliente (cpf),
FOREIGN KEY (idFilme) REFERENCES filme (idFilme),
FOREIGN KEY (numeroSala) REFERENCES sala (numeroSala) 
ON DELETE CASCADE
ON UPDATE CASCADE
);

insert into filme (nome, genero, lancamento, duracao, classificacao) values ('Sonic 2','Animação','2022-04-07', 20200,'10 anos');
insert into filme (nome, genero, lancamento, duracao, classificacao) values ('Doutor Estranho no Multiverso da Loucura','Fantasia','2022-05-05', 20600,'14 anos');
insert into filme (nome, genero, lancamento, duracao, classificacao) values ('Jujutsu Kaisen 0','Anime','2022-04-28', 14500,'14 anos');
insert into filme (nome, genero, lancamento, duracao, classificacao) values ('Medida Provisória','Drama','2022-04-14', 13400,'14 anos');
insert into filme (nome, genero, lancamento, duracao, classificacao) values ('Jurassic World: Domínio','Ficção Científica','2022-06-02', 22700,'12 anos');
insert into filme (nome, genero, lancamento, duracao, classificacao) values ('Cidade Perdida','Aventura','2022-04-21', 15200,'14 anos');
insert into filme (nome, genero, lancamento, duracao, classificacao) values ('A Medium','Terror','2022-05-19', 21100,'16 anos');
insert into filme (nome, genero, lancamento, duracao, classificacao) values ('D. P. A. 3 - Uma Aventura no Fim do Mundo','Comédia','2021-01-07', 10200,'Livre');
insert into filme (nome, genero, lancamento, duracao, classificacao) values ('Batman','Ação','2022-03-03', 25600, '14 anos');
insert into filme (nome, genero, lancamento, duracao, classificacao) values ('The Joker', 'Drama', '2019-10-04', 20200, '16 anos');

insert into cliente values
('12345678900', 'Matheus Germano','2003-02-27', 'dev.mgermano@gmail.com', 'MTIz'),
('00987654321', 'Matheus Costa','2000-02-04', 'matheus.sico@hotmail.com', 'MTIz'),
('11111111111', 'Angelo Holandini','2003-02-05', 'angelo.holandini@gmail.com', 'MTIz'),
('22222222222', 'Joao Silva','2004-02-05', 'joao.silva@gmail.com', 'MTIz'),
('33333333333', 'Carlos Pereira','2010-02-05', 'carlos.pereira@gmail.com', 'MTIz'),
('44444444444', 'Kleber Silva','2007-02-05', 'kleber.silva@gmail.com', 'MTIz'),
('55555555555', 'Eduardo Sousa','1997-02-05', 'eduardo.sousa@gmail.com', 'MTIz'),
('66666666666', 'Marcela Pereira','2005-02-05', 'marcela.pereira@gmail.com', 'MTIz'),
('77777777777', 'Taina Damasco','2006-02-05', 'taina.damasco@gmail.com', 'MTIz'),
('88888888888', 'Estela Costa','2003-02-05', 'estela.costa@gmail.com', 'MTIz');

insert into sala values
(1, 100),
(2, 100),
(3, 140),
(4, 140),
(5, 80),
(6, 80),
(7, 40),
(8, 40),
(9, 70),
(10, 70);

INSERT INTO ticket VALUES
(default,'12345678900','1','2','14.00','2022-01-23 12:45:00','B22','0','0','1'),
(default,'00987654321','3','7','14.00','2022-05-13 04:30:00','C03','1','0','1'),
(default,'88888888888','2','2','28.00','2022-04-10 08:40:00','J45','0','0','0'),
(default,'33333333333','9','4','28.00','2022-04-21 09:00:00','M40','1','1','0'),
(default,'77777777777','8','4','28.00','2022-03-29 12:45:00','A47','1','0','0'),
(default,'12345678900','6','7','14.00','2022-06-02 10:10:00','E35','0','1','1'),
(default,'22222222222','3','6','28.00','2022-02-12 05:45:00','B24','0','0','0'),
(default,'11111111111','4','2','14.00','2022-02-07 07:25:00','H32','0','1','1'),
(default,'12345678900','6','4','14.00','2022-06-05 04:30:00','J13','0','1','1'),
(default,'00987654321','1','2','14.00','2022-01-15 02:10:00','D33','0','1','1');

select * from cliente;

-- Consulta Nome, Preço e Data dos ingressos comprados
SELECT cliente.nome as 'Nome do Cliente', ticket.preco as 'Preço do Ticket', date_format(ticket.datahora,"%d/%m/%Y %h:%i:%s") as 'Data e Hora da Sessão'
	FROM cliente inner join ticket on cliente.cpf = ticket.cpfCliente;

-- Salas que tiveram sessões compradas e seus lucros
SELECT distinct sala.numeroSala as 'Número da Sala', sum(ticket.preco) as 'Lucro'
	FROM sala inner join ticket on sala.numeroSala = ticket.numeroSala
    group by sala.numeroSala
    order by lucro asc;

-- Filmes e seus detalhes, junto das sessões em que passaram 
SELECT filme.nome as 'Nome do Filme', filme.genero as 'Gênero', date_format(filme.lancamento,"%d/%m/%Y") as 'Data de Lançamento', 
					ticket.idTicket as 'ID da Sessão',date_format(ticket.datahora,"%d/%m/%Y %h:%i:%s") as 'Data e Hora da Sessão'
	FROM filme right join ticket on filme.idFilme = ticket.idFilme
    group by ticket.idTicket
    order by ticket.idTicket asc;

    
-- testes    
-- select nome as 'Nome', genero as 'Gênero', date_format(lancamento,"%d/%m/%Y") as 'Data de Lançamento', duracao as 'Duração', classificacao as 'Classificação' from filme order by nome;
-- select CPF, Nome, date_format(dataNascimento,"%d/%m/%Y") as 'Data de Nacimento', email as 'e-Mail', senha as 'Senha' from cliente order by nome;

select * from cliente where cpf = "12345678900" and senha = "MTIz";

delete from cliente where cpf = "11223344550" or cpf = "11223344556";
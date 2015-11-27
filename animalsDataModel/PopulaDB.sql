delete from RegistroAnimal;
delete from EstadoAnimal;

insert into EstadoAnimal values ('Fome');
insert into EstadoAnimal values ('Doente');
insert into EstadoAnimal values ('Assustado');
insert into EstadoAnimal values ('Raivoso');

delete from TipoAnimal;

insert into TipoAnimal values ('Gato');
insert into TipoAnimal values ('Cachorro');
insert into TipoAnimal values ('Outro');


delete from SituacaoAnimal;


insert into SituacaoAnimal values ('Nenhuma providencia foi tomada');
insert into SituacaoAnimal values ('Recebeu comida');
insert into SituacaoAnimal values ('Recebeu cuidados medicos');
insert into SituacaoAnimal values ('Recebeu auxilio');
insert into SituacaoAnimal values ('Transportado para abrigo');
insert into SituacaoAnimal values ('Animal com raiva e stressado');
insert into SituacaoAnimal values ('Não Encontrado');
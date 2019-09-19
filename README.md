# TEV.TEST.API
Test Tu equipo virtual


Metodos Api probados en postman

GET
http://localhost:41500/TEV/USER
Deveuleve todos los registros 

GET
http://localhost:41500/TEV/USER/GetUserById/1
Deveuelve un registros segun el codigo del usuario

POST
http://localhost:41500/TEV/User
Crea un usuario
{
   "id":3,
   "lastName": "Patiño",
   "address": "Cll 1, Casa 1",
   "createDate": "12/12/2019",
   "updateDate": "12/12/2019"
}

PUT
http://localhost:41500/TEV/User
Edita un usuario
{
   "id":3,
   "lastName": "Patiño Miguel",
   "address": "Cll 1, Casa 1",
   "createDate": "12/12/2019",
   "updateDate": "12/12/2019"
}

DELETE
http://localhost:41500/TEV/USER/1
Elimina un usario segun codigo del usuario

# netmicro-eventsourcing

Overview
![image](https://github.com/lehoangpl2020/netmicro-eventsourcing/assets/115392816/18155fb9-de7f-4f22-983b-a154c41174fe)


# Run docker up
docker-compose up -d

# Mongo db
docker pull mongo

docker run -it -d --name mongo-container -p 27017:27017 --restart always -v mongodb_data_container:/data/db mongo:latest

docker run -it -d --name mongo-container -p 27017:27017 --network mydockernetwork --restart always -v mongodb_data_container:/data/db mongo:latest

Download Client Tools – Robo 3T:
https://robomongo.org/download

# SQL server
docker run -d --name sql-container \
--network mydockernetwork \
--restart always \
-e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=$tr0ngS@P@ssw0rd02' -e 'MSSQL_PID=Express' \
-p 1433:1433 mcr.microsoft.com/mssql/server:2017-latest-ubuntu 


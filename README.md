# netmicro-eventsourcing

Overview
![image](https://user-images.githubusercontent.com/115392816/204140288-13ab2aaf-87e4-4dcc-ab30-4dc29275d6c2.png)

# Mongo db
Run in Docker:
docker run -it -d --name mongo-container \
-p 27017:27017 --network mydockernetwork \
--restart always \
-v mongodb_data_container:/data/db \
mongo:latest

Download Client Tools – Robo 3T:
https://robomongo.org/download

# SQL server
docker run -d --name sql-container \
--network mydockernetwork \
--restart always \
-e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=$tr0ngS@P@ssw0rd02' -e 'MSSQL_PID=Express' \
-p 1433:1433 mcr.microsoft.com/mssql/server:2017-latest-ubuntu 


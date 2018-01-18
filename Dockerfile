FROM microsoft/dotnet:2.0.5-sdk-2.1.4-jessie

WORKDIR /app

# copy project.json and restore as distinct layers
#COPY *.csproj .
#RUN dotnet restore

# copy and build everything else
COPY . .
#RUN dotnet publish -o out
ENTRYPOINT ["dotnet", "out/dotnetdock.dll"]

EXPOSE 3000

# create project
- dotnet new console -lang="F#" -o="src"

# ping確認
- dotnet add package Microsoft.AspNetCore
- dotnet add package Microsoft.AspNetCore.App
- dotnet watch
- curl -v http://localhost:5000/ping

# 犬種固定で返す
- curl -v http://localhost:5000/dog

# usecase,domainの定義をして、犬種固定で返す
- curl -v http://localhost:5000/dog

# Port, Driver, Gatewayを追加した(DIはまだ)
- curl -v http://localhost:5000/dog
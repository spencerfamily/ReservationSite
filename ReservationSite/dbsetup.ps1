$dbs = dotnet ef dbcontext list
$dbs | %{dotnet ef database update --context $_}
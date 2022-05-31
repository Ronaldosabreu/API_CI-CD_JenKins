pipeline{
    agent any
    
    stages{
        stage('Inicial')
        {
            steps
			{
                echo 'Teste de pepilene'
            }
        }
		 stage('Build')
        {
            steps
			{
                bat "dotnet build jenkins.csproj --configuration Release"
            }
        }
    }
 }
 
 
   stage('Inicial')
        {
            steps
			{
                echo 'Teste de pepilene'
            }
        }
		 stage('Build API')
        {
            steps
			{
                bat "dotnet build jenkins --configuration Release"
            }
        }
        stage('Build API Test')
        {
            steps
			{
                bat "dotnet build /jenkinsAPIteste --configuration Release"
            }
        }
    	stage('Test')
        {
            steps
			{
                bat "dotnet test jenkinsAPIteste"
            }
        }
        	stage('Run')
        {
            steps
			{
                bat "dotnet run --project jenkins"
            }
        }
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
                bat "dotnet build jenkins --configuration Release"
            }
        }
         stage('Build Test')
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
    }
 }
 
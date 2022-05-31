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
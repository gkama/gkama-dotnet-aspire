# gkama-dotnet-aspire
.NET Aspire Project

## Documentation

https://learn.microsoft.com/en-us/dotnet/aspire/deployment/overview#deploy-to-kubernetes
https://medium.com/@josephsims1/aspire-aspi8-deploy-microservices-effortlessly-with-cli-no-docker-or-yaml-needed-f30b58443107

**The Aspir8 project**
Aspir8, an open-source project, handles the generation of deployment YAML based on the .NET Aspire app host manifest. The project outputs a .NET global tool that can be used to perform a series of tasks, resulting in the generation of Kubernetes manifests:

`aspirate init`: Initializes the Aspir8 project in the current directory.
`aspirate generate`: Generates Kubernetes manifests based on the .NET Aspire app host manifest.
`aspirate apply`: Applies the generated Kubernetes manifests to the Kubernetes cluster.
`aspirate destroy`: Deletes the resources created by the apply command.
With these commands, you can build your apps, containerize them, and deploy them to Kubernetes clusters. For more information, see Aspir8.
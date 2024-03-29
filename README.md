# AKS demo

This is a demo to show how we can deploy ASP.NET web api into AKS.

Creating docker image and push to dockerhub has been done with GitHub action, then pull the image
from dockerhub and deploy to AKS has been done manually. I was getting some issues related to Azure 
login from GitHub action, so I manually deployed the containers to AKS.

Steps to manually deploy to AKS with dockerhub image:

- Create a new AKS resource in Azure
- Login to Azure PowerShell from your local computer or use CloudShell
- Install `kubectl` in your local machine if not already. If you are using CloudShell then `kubectl` is already
installed
- Import AKS credentials

```
Import-AzAksCredential -ResourceGroupName <resource group name> -Name <aks name>
```

- Deploy to AKS (`aks-deploy.yml` is in the root of the repo)

```
kubectl apply -f aks-deploy.yml
```

- Check the nodes and pods

```
kubectl get nodes

kubectl get pods
```

- Get the external ips of the services (you can also get the external ips from Azure Portal)

```
kubectl get service api1

kubectl get service api2
```

- Open web browser and navigate to the url and you should be able to see the output

```
http://<api 1 external ip>/HelloApi?name=Jon

http://<api 2 external ip>/HelloApi?name=Jon
```

Full tutorial
[here](https://docs.microsoft.com/en-us/azure/aks/tutorial-kubernetes-prepare-app).
# Maratona Xamarin
Source code do projeto de revisão do módulo básico. Este projeto implementar uma aplicação conectada ao um servidor RESt utilizando as plataformas Android e iOS com uma api compartilhada. 

## Post para receber a lista do servidor REST
Estrutura do Post utilizado para pegar os dados no servidor hospedado no Azure. Utilizar como referência para implementação semelhante no Heroku. 

```
POST /api/monkeys HTTP/1.1
X-ZUMO-FEATURES: AT
X-ZUMO-INSTALLATION-ID: 9dfd4be9-f49d-4642-a302-a0a700021ed3
Accept: application/json
User-Agent: ZUMO/3.1 (lang=Managed; os=Android; os_version=5.1; arch=Unix; version=3.1.50105.0)
X-ZUMO-VERSION: ZUMO/3.1 (lang=Managed; os=Android; os_version=5.1; arch=Unix; version=3.1.50105.0)
ZUMO-API-VERSION: 2.0.0
Content-Type: application/json; charset=utf-8
Content-Length: 144
Connection: keep-alive
Host: 192.168.1.231
Accept-Encoding: gzip

{
  "id": "f6932c29-fff5-4e96-b32d-e344965c35bc",
  "name": "Angelo",
  "email": "angelo@angelo.com",
  "city": "Carapicuiba",
  "state": "SP"
}

```
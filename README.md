# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, foram utilizados os conhecimentos adquiridos no módulo de orientação a objetos da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone, de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
Como solução do desafio, foram criadas as classes **Nokia** e **Iphone**, com a devida implementação em ambas do método abstrato *InstalarAplicativo*.

Também foram colocados em prática conceitos de orientação a objetos como herança (já que as duas herdam da classe **Smartphone**), polimorfismo (no caso de métodos abstratos) e abstração (por ser a proposta do desafio). 
Além disso, como nova funcionalidade, foi feita a simulação de uma assistente virtual, como a Siri (no caso do Iphone) e o Google Assistente (no caso do Nokia), através do consumo da API do ChatGPT. 

A implementação ocorre no método assíncrono da classe Smartphone *FalarComChatGPT*, que realiza uma requisição do tipo POST para a API do ChatGPT, passando a chave da API como header de autorização e desserializando as respostas da inteligência artificial para que possam ser acessadas facilmente.
Essa função é chamada em ambas as implementações do método abstrato da classe **Smartphone** *ChamarAssistenteVirtual*.

## Atenção 
A variável **API_KEY** será excluída após a publicação deste código por motivos de segurança. Para que a aplicação funcione adequadamente, é necessário substituir o valor dessa variável por sua própria chave, de forma local.

Em caso de dúvidas, acesse: [OpenAI](https://platform.openai.com/docs/api-reference).

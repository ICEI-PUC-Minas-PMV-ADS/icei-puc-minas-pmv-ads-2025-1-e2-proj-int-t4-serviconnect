# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas
 




<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/AnaClara1.png" alt="Persona1"/>

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> 
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:


| Nome             | Idade | Profissão                        | Frustrações                                                                 | Expectativas                                                                 |
|-----------------|------|--------------------------------|-----------------------------------------------------------------------------|------------------------------------------------------------------------------|
| João Souza     | 35   | Analista de TI                 | Dificuldade em encontrar prestadores confiáveis; demora na resposta para orçamentos; falta de transparência na qualidade dos serviços. | Encontrar profissionais qualificados rapidamente; visualizar avaliações e histórico dos prestadores; ter um canal de comunicação eficiente. |
| Mariana Ferreira | 28   | Designer de interiores        | Pouca visibilidade no mercado; dificuldade em gerenciar solicitações de clientes; problemas na comunicação com clientes. | Plataforma que facilite a gestão dos pedidos; um espaço para exibir portfólio e avaliações; receber pagamentos de forma organizada. |
| Lucas Almeida   | 42   | Dono de empresa de manutenção | Processo demorado para contratar prestadores qualificados; dificuldade em acompanhar o andamento dos serviços; problemas com a qualidade do trabalho entregue. | Plataforma que agilize a contratação; possibilidade de agendar e acompanhar serviços; sistema que garanta prestadores bem avaliados. |
| Pedro Santos   | 50   | Jardineiro                     | Dificuldade em conseguir novos clientes; problemas com pagamentos atrasados; falta de visibilidade para seus serviços. | Plataforma que conecte com clientes em potencial; sistema de pagamentos seguro e organizado; espaço para exibir avaliações e fotos de trabalhos realizados. |
| Carla Menezes  | 33   | Massoterapeuta                 | Concorrência alta no mercado; dificuldade em fidelizar clientes; pouca divulgação do trabalho. | Plataforma que ajude na captação de clientes; agendamento facilitado; espaço para avaliações e feedbacks positivos. |

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Ana Clara  | Uma forma de identificar se uma agência é realmente confiável           | Me sentir mais segura ao contratar seus serviços               |
|Ana Clara       | Ter um mecanismo eficiente e rápido de comunicação                 | Que eu possa sanar todas as minhas dúvidas rapidamente |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Usuários conseguirem realizar cadastro no sistema  | ALTA | 
|RF-002| Usuários conseguirem realizar a recuperação de senha.   | ALTA |
|RF-003| Usuarios consegurem excluiir a propria conta. | ALTA |
|RF-004| Usuarios deve conseguir abrir chamado de serviços terceiros.  | ALTA |
|RF-005| Prestador de serviço deve tere acesso à um calendário mensal para visualização de cronograma. | ALTA |
|RF-006| Usuario deve ter acesso a ter um cronograma no calendario para os serviços terceiros. | MÉDIA|
|RF-007| Usuarios devem conseguir efetuar comentários e avaliar serviços. | MÉDIA |
|RF-008| Usuarios receber notificações sobre confirmação de agendamento de serviços. | MÉDIA |
|RF-009| Usuarios com melhores infomações devem ser mais recomendados| ALTA |
|RF-010| O sistema deve conter uma ferramenta e busca para serviços terceiros. | ALTA |
|RF-011| O sistema deve conter um dashboard com informacoes dos serviços mais solicitados. | MÉDIA |
|RF-012| Usuários deve pertir favoritar colabor de serviços terceiros.  | BAIXA |
|RF-013| Prestadores de serviços devem ter foto de perfil verificada. | MÉDIA |
|RF-014| Prestador de serviço deve fornecer suas rede sociais na plataforma  | MÉDIA|
|RF-015| Prestadores de serviços devem ter mais de 21 anos para fazer o cadastro na plataforma.  | MÉDIA|

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser disponibilizada em um ambiente acessível ao público na Internet.  | ALTA | 
|RNF-002| A aplicação deverá ser responsivo, possibilitando a visualização otimizada em diversos dispositivos, tais como computadores, celulares, entre outros.  |  MÉDIA | 
|RNF-003| A aplicação deve apresentar compatibilidade com diversos navegadores ex: Safari, Chrome, Edge e Fire Mozila   |  ALTA | 
|RNF-004| A aplicação deve otimizar o desempenho do site a fim de assegurar tempos de carregamento rápidos  “3s”.   |  ALTA | 
|RNF-005| O site deve ser fácil de usar, com uma interface intuitiva que permita aos usuários encontrar rapidamente as informações e funcionalidades que procuram máximo 5 clicks .  |  ALTA | 
|RNF-006| Deverá conseguir incluir o modo escuro na aplicação.   |  ALTA | 
|RNF-007| O site deve seguir padrões de codificação e design web, como HTML5, CSS3, C# e JavaScript moderno, para garantir a compatibilidade e a manutenção futura  |  ALTA | 
|RNF-007|Apliacao podera ser utlizada em WindowS, IOS E Android de forma Web  |  ALTA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso


![WhatsApp Image 2025-03-06 at 20 53 52](https://github.com/user-attachments/assets/81e596c5-d28e-4778-ac0b-2d59f58a0170)



> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

 
<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 <tr>
  <td>CT-01: verificar funcionamento e responsividade do cadastro</td>
  <td>
   <ul>
    <li>RF-001:Usuários conseguirem realizar cadastro no sistema.</li>
   </ul>
  </td>
  <td>Verificar se o cadastro está sendo concluido com êxito </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Clicar em login/cadastro</li>
    <li>verificar se caixas de texto estão funcionando</li>
     <li>colocar credenciais obrigatórias</li>
    <li>Clicar em registrar.</li>
   </ol>
   </td>
  <td> link do site,todas as caixas de texto e botões devem funcionar, responderem com agilidade e o registro deve ser feito </td>
  <td>--------</td>
 </tr>
<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 

<tr>
  <td>CT-02: verificar funcionamento e responsividade dá página de esqueci minha senha</td>
  <td>
   <ul>
    <li>RF-002:Usuários conseguirem realizar a recuperação de senha.</li>
   </ul>
  </td>
  <td>Verificar se a senha sera recuperada </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>clicar no botão de "esqueci minha senha"</li>
    <li>ver se a caixa de nova senha está funcionando</li>
     <li>colocar senha nova na caixa de texto</li>
   <li>clicar em trocar senha e ver se a senha foi trocada </li>
   </ol>
   </td>
  <td>  não pode ser confuso!. link do site, as caixas e botões devem funcionar e a senha deve ser mudada </td>
  <td>--------</td>
 </tr>
 <table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-03: verificar funcionamento da exclusão de conta</td>
  <td>
   <ul>
    <li>RF-003:O sistema deve permitir que os usuários tenham acesso a realizar a excluzam da sua propria conta..</li>
   </ul>
  </td>
  <td>Excluir a propia conta </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão do seu própio perfil</li>
   <li>clicar no botão de excluir</li> 
    <li>verificar se a exclusão foi concluida</li> 
   </ol>
   </td>
  <td>  link do site, caixas de texto e botões funcionando corretamente. Exclusão da conta concluida de maneira correta </td>
  <td>--------</td>
 </tr>

  <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-04: O sistema deve permitir que os prestadores tenham acesso ao cadastramento de suas devidas funções.</td>
  <td>
   <ul>
    <li>RF-004	O sistema deve permitir que os prestadores tenham acesso ao cadastramento de suas devidas funções</li>
   </ul>
  </td>
  <td>cadastrar as funções do prestador do serviço </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão do seu própio perfil</li>
    <li>clicar para editar perfil</li> 
    <li>clicar nas caixas de texto </li> 
    <li>colocar credencias de serviço e de contato</li> 
    <li>clicar em concluir,ver se foi com êxito</li> 
   </ol>
   </td>
  <td>  link do site, caixas de texto e botões funcionando corretamente. edição do perfil do prestador ser concluida com êxito </td>
  <td>--------</td>
 </tr>

<tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-05:	O sistema deve permitir que os usuários tenham acesso a abrir chamado de serviços terceiros..</td>
  <td>
   <ul>
    <li>RF-005	O sistema deve permitir que os usuários tenham acesso a abrir chamado de serviços terceiros.</li>
   </ul>
  </td>
  <td>abrir chamado de serviço </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão de inicio</li>
    <li>analisar um serviço que é preciso</li> 
    <li>clicar no prestador </li> 
    <li>clicar no calendário e escolher sua data de serviço</li> 
    <li>clicar em concluir e marcar seu serviço</li> 
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, calendário funcionando corretamente e chamado abrido com êxito </td>
  <td>--------</td>
 </tr>

<tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td> CT-06:	O sistema deve permitir que os prestadores de serviço devem ter acesso à um calendário mensal para visualização de cronograma..</td>
  <td>
   <ul>
    <li>RF-006	O sistema deve permitir que os prestadores de serviço devem ter acesso à um calendário mensal para visualização de cronograma.</li>
   </ul>
  </td>
  <td>abrir calendário ná página inicial do prestador </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão de inicio</li>
    <li>analisar caléndario</li> 
    <li>ver cronograma</li>  
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, calendário funcionando corretamente e cronograma atualizado no inicio </td>
  <td>--------</td>
 </tr>

 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-07:	O sistema deve permitir que os usuários tenham acesso a efetuar comentários e avaliar serviços.</td>
  <td>
   <ul>
    <li>RF-007	O sistema deve permitir que os usuários tenham acesso a efetuar comentários e avaliar serviços.</li>
   </ul>
  </td>
  <td>comentários e avaliação do serviço funcionar corretamente </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão de inicio</li>
    <li>entrar num perfil onde o serviço já foi prestado</li> 
    <li>avaliar o serviço pelos botões</li>
    <li>deixar comentário no local apropiado.</li>
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, aréa de comentários funcionando com Êxito</td>
  <td>--------</td>
 </tr>

<tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-08:	O sistema deve permitir que os usuários tenham acesso receber notificações sobre confirmação de agendamento de serviços.</td>
  <td>
   <ul>
    <li>RF-008	O sistema deve permitir que os usuários tenham acesso receber notificações sobre confirmação de agendamento de serviços.</li>
   </ul>
  </td>
  <td>notificações chegando de maneira correta </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão de inicio</li>
    <li>clicar no sininho de notificações</li> 
    <li>analisar notificações recebidas.</li>
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, botão de notificações localizado no inicio do site e notifições chegando apropiadamente</td>
  <td>--------</td>
 </tr>

 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-09: O sistema deve permitir que os prestadores com melhores notas sejam recomendados</td>
  <td>
   <ul>
    <li>RF-009	O sistema deve permitir que os prestadores com melhores notas sejam recomendados</li>
   </ul>
  </td>
  <td>os recomendados dá página inicial devem ter boas notas</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão de inicio</li>
    <li>analisar prestadores</li> 
    <li>analisar se as notas dos prestadores estão boas</li>
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, notas dos primeiros prestadores de serviço que aparecer devem estar boas</td>
  <td>--------</td>
 </tr>

 tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-10:	O sistema deve conter uma ferramenta e busca para serviços terceiros.</td>
  <td>
   <ul>
    <li>RF-010	O sistema deve conter uma ferramenta e busca para serviços terceiros.</li>
   </ul>
  </td>
  <td>a ferramenta de busca para serviços deve funcionar</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão de inicio</li>
    <li>analisar caixa de busca</li> 
    <li>colocar serviço desejado</li>
    <li>analisar busca de serviço</li>
    <li>chamar serviço desejado</li>
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, caixa de pesquisa funcionar corretamente, serviço desejado aparecer na tela.</td>
  <td>--------</td>
 </tr>

  tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-11:	O sistema deve conter um dashboard com informacoes dos serviços mais solicitados.</td>
  <td>
   <ul>
    <li>RF-011	O sistema deve conter um dashboard com informacoes dos serviços mais solicitados.</li>
   </ul>
  </td>
  <td>o dashboard deve funcionar corretamente e mostrar os serviçõs mais solicitados</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão de inicio</li>
    <li>analisar dashboard de inicio</li> 
    <li>analisar notas dos prestadores</li>
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, dashboard de inicio funcionar corretamente, e mostrar pedido com melhores notas e mais solicitados</td>
  <td>--------</td>
 </tr>

 tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-12:	O sistema deve permitir que os usuários tenham acesso a favoritar colaboradores de serviços terceiros.</td>
  <td>
   <ul>
    <li>RF-012	O sistema deve permitir que os usuários tenham acesso a favoritar colaboradores de serviços terceiros.</li>
   </ul>
  </td>
  <td>botão de favoritar o colaborador de serviço funcionando com êxito</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão de inicio</li>
    <li>analisar dashboard de inicio</li> 
    <li>analisar prestadores</li>
    <li>favoritar prestador desejado</li>
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, dashboard de inicio funcionar corretamente, botão de favorito aparecer e funcionar corretamente e prestador ser favoritado com êxito</td>
  <td>--------</td>
 </tr>
 tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-13: O sistema deve permitir que os prestadores de serviço deve fornecer suas rede sociais na plataforma</td>
  <td>
   <ul>
    <li>RF-013	O sistema deve permitir que os prestadores de serviço deve fornecer suas rede sociais na plataforma</li>
   </ul>
  </td>
  <td>no perfil do prestador deve poder colocar as redes sociais</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>clicar no botão entrar</li>
    <li>clicar no botão de inicio</li>
    <li>clicar no seu perfil</li> 
    <li>clicar nas caixas de rede social</li>
    <li>informar redes desejadas e obter Êxito</li>
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, dashboard de inicio funcionar corretamente, botão de perfil funcionar corretamente e caixa de redes funcionar com êxito</td>
  <td>--------</td>
 </tr>

 tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-14:	O sistema deve permitir que os prestadores de serviços devem ter mais de 21 anos para fazer o cadastro na plataforma.</td>
  <td>
   <ul>
    <li>RF-014	O sistema deve permitir que os prestadores de serviços devem ter mais de 21 anos para fazer o cadastro na plataforma.</li>
   </ul>
  </td>
  <td>o prestador tera mais de 21 anos</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais</li>
    <li>mostrar e provar que tem mais de 21 anos</li>
    <li>clicar no botão de entrar</li>
    <li>ir para página de inicio </li>
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, cadastro e forma de mostrar que tem mais ou 21 anos funcionando corretamente</td>
  <td>--------</td>
 </tr>

  tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
<tr>
  <td>CT-15: O administrador terá acesso a excluir o perfil de serviço do prestador.</td>
  <td>
   <ul>
    <li>RF-015	O administrador terá acesso a excluir o perfil de serviço do prestador.</li>
   </ul>
  </td>
  <td>o administrador excluira o perfil do prestador com sucesso</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site "".</li>
    <li>Visualizar a página de login</li>
    <li>colocar credenciais de admin</li>
    <li>clicar no botão de entrar</li>
    <li>ir para página de inicio </li>
    <li> ir até perfil de prestador que sera exluido </li>
    <li>ir para aréa de exclusão</li>
    <li>clicar em bottão de excluir</li>
   </ol>
   </td>
  <td>  link do site, caixas de texto , botões funcionando corretamente, aréa de exclusão e botão de excluir funcionando corretamente</td>
  <td>--------</td>
 </tr>

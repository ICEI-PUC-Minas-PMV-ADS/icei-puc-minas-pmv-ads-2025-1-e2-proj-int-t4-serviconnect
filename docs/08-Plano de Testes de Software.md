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
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página de cadastro</li>
    <li>verificar se caixas de texto estão funcionando</li>
    <li>completar registro e concluir se foi feito com êxito.</li>
   </ol>
   </td>
  <td> todas as caixas de texto e botões devem funcionar, responderem com agilidade e o registro deve ser feito </td>
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
    <li>RF-001:Usuários conseguirem realizar cadastro no sistema.</li>
    <li>RF-002:Usuários conseguirem realizar a recuperação de senha.</li>
   </ul>
  </td>
  <td>Verificar se a senha sera recuperada </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página de login</li>
    <li>clicar no botão de "esqueci minha senha"</li>
    <li>ver se a caixa de nova senha está funcionando</li>
   <li>completar tentativa e ver se a senha foi trocada </li>
   </ol>
   </td>
  <td>  não pode ser confuso, as caixas e botões devem funcionar e a senha deve ser mudada </td>
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
<tr>
  <td>CT-03: verificar funcionamento e responsividade da index</td>
  <td>
   <ul>
    <li>RF-009:Usuarios com melhores infomações devem ser mais recomendados.</li>
    <li>RF-010:O sistema deve conter uma ferramenta e busca para serviços terceiros.</li>
    <li>RF-011:O sistema deve conter um dashboard com informacoes dos serviços mais solicitados.</li>
    <li>RF-012:Usuários devem poder favoritar colaboradores de serviços terceiros.</li>
    <li>RF-013:Prestadores de serviços devem ter foto de perfil verificada..</li>
    <
   </ul>
  </td>
  <td>verificar o funcionamento geral da index</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página de login</li>
    <li>cocncluir login</li>
    <li>chegar na página index</li>
   <li>testar botões dá página </li>
   <li> testar busca da página </li>
   <li> ver média de notas dos serviços</li>
   <li>favoritar serviços </li>
   </ol>
   </td>
  <td>  os botões e caixa de busca dá página index estão funcionando e etão responsivos com êxito</td>
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
<tr>
  <td>CT-04: verificar funcionamento e responsividade dos perfis dos prestadores de serviço </td>
  <td>
   <ul>
    <li>RF-007:Usuarios devem conseguir efetuar comentários e avaliar serviços.</li>
    <li>RF-013:Prestadores de serviços devem ter foto de perfil verificada..</li>
    <li>RF-014:Prestador de serviço deve fornecer suas rede sociais na plataforma.</li>
    <li>RF-015:Prestadores de serviços devem ter mais de 21 anos para fazer o cadastro na plataforma.</li>
    <
   </ul>
  </td>
  <td>verificar o funcionamento dá página de perfil</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página de login</li>
    <li>cocncluir login</li>
    <li>chegar na página index</li>
   <li>clicar em perfil de algum prestador </li>
   <li> analisar se a foto está verificada</li>
   <li> verificar redes sociais</li>
   <li>avaliar serviço</li>
   </ol>
   </td>
  <td>  hyperlinks funcionandos, dados corretos,bem dispostos e avaliação enviada com êxito</td>
  <td>--------</td>
 </tr>


# Resumo
Diante da necessidade e visando mais comodidade para os alunos da Universidade Federal de Mato Grosso, Campus Cuiabá, no que diz respeito à locomoção pelo campus, o professor Irapuan Noce Brazil viu a possibilidade de utilizar essa necessidade para que os alunos da disciplina de Gerência de Projetos colocassem em prática o conteúdo abordado em sala de aula. Sendo assim, este projeto visa desenvolver uma aplicação de rastreamento para o ônibus escolar "Ligeirão" da Universidade Federal de Mato Grosso (UFMT), com o objetivo de melhorar a eficiência e a segurança na locomoção dos alunos. Os autores, André Luiz da Silva Santos e Jamily Magalhães da Silva, liderarão o desenvolvimento do protótipo como parte de um projeto acadêmico na disciplina de Gerência de Projetos.

# Propósito
## Necessidade
O projeto foi desenvolvido devido à necessidade de melhorar a eficiência, segurança e comodidade na locomoção dos alunos da UFMT.

## Objetivo de negócio
- Desenvolver um protótipo funcional de rastreamento.
- Proporcionar uma experiência prática de desenvolvimento de software para os autores.
- Demonstrar a viabilidade do sistema de rastreamento como solução logística.

# Descrição do projeto
O projeto de Tracking do Ônibus Escolar "Ligeirão" tem como objetivo principal melhorar a eficiência e a segurança na locomoção dos alunos pela Universidade Federal de Mato Grosso (UFMT). Isso será alcançado através do desenvolvimento de uma aplicação de rastreamento que permitirá aos alunos acompanhar em tempo real a localização do ônibus. O projeto utilizará tecnologia avançada, incluindo hardware e software de rastreamento, para garantir a precisão e a confiabilidade do sistema. Todos os componentes serão integrados à infraestrutura de TI existente da UFMT, garantindo que os sistemas e processos atuais continuem funcionando sem interrupções. O projeto busca não apenas melhorar a experiência dos alunos, mas também demonstrar a viabilidade do sistema de rastreamento como uma solução eficaz para melhorar a logística de transporte dentro da universidade.

# Riscos
- Possíveis atrasos na entrega devido à dificuldade na aquisição de componentes de hardware ou problemas técnicos durante o desenvolvimento.
- Restrições de tempo devido a outras responsabilidades acadêmicas dos autores podem afetar o progresso do projeto.
- A dependência de fornecedores externos para a entrega de hardware pode resultar em atrasos no desenvolvimento.

# Entregáveis do Projeto
O principal entregável do projeto será um protótipo funcional da aplicação de rastreamento.

# Cronograma Sumário de Marcos
O cronograma detalhado será desenvolvido em etapas, com marcos importantes, como análise de requisitos, design, desenvolvimento, testes e implantação, sendo monitorados regularmente para garantir o progresso dentro do prazo estabelecido. Espera-se que o protótipo esteja pronto para demonstração dentro de 3 semanas a partir do início do projeto.

## Cronograma
| Marcos do projeto           | Data alvo   |
|----------------------------|------------|
| Início do projeto          | 18/03/2024 |
| Desenvolvimento do design  | 21/03/2024 |
| Aquisição de hardware e software | 21/03/2024 |
| Desenvolvimento da solução | 29/03/2024 |
| Testes                     | 01/04/2024 |
| Implantar solução          | 04/04/2024 |
| Projeto Concluído          | 05/04/2024 |

# Orçamento
A tabela a seguir contém um orçamento resumido com base nos componentes de custo planejados e nos custos estimados necessários para a conclusão bem-sucedida do projeto.

| Componente               | Custo   |
|-------------------------|--------|
| Raspberry Pi Zero W     | R$ 285,00 |
| GPS USB                 | R$ 149,00 |
| Amazon Location Service | R$ 100,00 |
| **Total**               | **R$ 534,00** |

# Critérios de sucesso
O projeto será considerado um sucesso se os seguintes critérios forem atingidos:
- Criação da tela frontend com as funcionalidades especificadas.
- Desenvolvimento do backend para tratamento e comunicação dos dados.
- Programação do Raspberry Pi para envio dos dados do GPS para o backend.
- Integração dos componentes do sistema (frontend, backend e Raspberry Pi).
- Apresentação de um protótipo funcional que atenda às expectativas dos usuários e da UFMT.

# Gerente do Projeto
André Luiz da Silva Santos será o gerente do projeto, responsável pela coordenação das atividades, alocação de recursos e comunicação com os stakeholders. Jamily Magalhães da Silva atuará como a principal responsável pelo desenvolvimento front-end da aplicação, trabalhando em estreita colaboração com o gerente do projeto.

# Execução
## Requisitos

| Identificador | Nome | Descrição | Tipo | Prioridade |
|--------------|------|-----------|------|------------|
| R01 | Captura de Localizações em Tempo Real | O sistema deve permitir a inserção de localizações dos veículos em tempo real. | Funcional | Alta |
| R02 | Armazenamento no Banco de Dados | O sistema deve permitir que as localizações sejam capturadas e armazenadas no banco de dados. | Funcional | Alta |
| R03 | Adição de Novos Veículos | O sistema deve permitir que sejam adicionados novos veículos ao sistema. | Funcional | Alta |
| R04 | Atributos de Veículos | O sistema deve permitir que cada veículo tenha um identificador único, uma descrição(nome) e uma placa. | Funcional | Alta |
| R05 | Adição de Pontos de Referência | O sistema deve permitir que sejam adicionados pontos de referências. | Funcional | Média |
| R06 | Detalhes dos Pontos de Referência | O sistema deve permitir que cada ponto de referência tenha um identificador único, uma descrição(nome), uma latitude e uma longitude. | Funcional | Média |
| R07 | Consulta Eficiente | O sistema deve ser capaz de buscar e recuperar dados do banco de dados para cada uma das operações mencionadas acima. | Funcional | Alta |
| R08 | Recuperação de Dados | O sistema deve permitir que as consultas ao banco de dados sejam eficientes e fornecer resultados precisos em tempo hábil. | Funcional | Alta |
| R09 | Exibição de Localizações | O sistema deve permitir que as localizações dos veículos e os pontos de referência sejam exibidos no front-end do sistema. | Funcional | Alta |
| R10 | Clareza na Renderização | O sistema deve permitir que a renderização seja clara e compreensível para os usuários. | Funcional | Alta |

# Codificação
A aplicação está dividida em:
- **Banco de dados**: Criado utilizando SQLServer com tabelas para controle de veículos, pontos de referência e localizações.
- **Back-end**: API desenvolvida em .Net Core (C#) para comunicação com o banco de dados e front-end.
- **Front-end**: Página HTML, CSS e JavaScript, utilizando a biblioteca Leaflet para renderizar um mapa com as localizações.

O código do projeto está disponível publicamente no GitHub: [Repositório Ligeirão](https://github.com/aandlss/Ligeirao).

# Teste
Foi criado um veículo fictício no banco de dados e um programa para inserir dados de uma rota teste. O código está disponível:
- [Program.cs](https://github.com/aandlss/Ligeirao/blob/master/GeraLocalizacoes/Program.cs)
- [mapaosm.html](https://github.com/aandlss/Ligeirao/blob/master/Front/mapaosm.html)

![Localização sendo traçada em teste](#)

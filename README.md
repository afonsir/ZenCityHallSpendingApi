# Packages:
* Microsoft.EntityFrameworkCore.Design
* AutoMapper
* AutoMapper.Extensions.Microsoft.DependencyInjection
* Npgsql.EntityFrameworkCore.PostgreSQL

dotnet add package NOME

# Model:
empenho

codigo
numero_processo
credor
descricao
funcao
sub_funcao
fonte_recurso
aplicacao
natureza
unidade_orcamentaria
programa
acao
tipo_licitacao
data_empenho     -> date
valor_empenhado  -> decimal
tipo_docto_fiscal
nro_docto_fiscal
data_liquidacao  -> date
valor_liquidado  -> decimal
data_pagamento   -> date
valor_pago       -> decimal

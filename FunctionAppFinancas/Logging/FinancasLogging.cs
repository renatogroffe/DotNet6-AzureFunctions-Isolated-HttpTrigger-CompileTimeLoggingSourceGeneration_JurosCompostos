using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace FunctionAppFinancas.Logging;

public static partial class FinancasLogging
{
    [LoggerMessage(EventId = 1, Level = LogLevel.Information,
        Message = "Recebida nova requisição|Valor do empréstimo: {valorEmprestimo}|Número de meses: {numMeses}|% Taxa de Juros: {percTaxa}")]
    public static partial void LogNovaRequisicao(
        this ILogger logger, double? valorEmprestimo, int? numMeses, double? percTaxa);

    [LoggerMessage(EventId = 2, Level = LogLevel.Information,
        Message = "Valor Final com Juros: {valorFinalJuros}")]
    public static partial void LogValorJuros(
        this ILogger logger, double? valorFinalJuros);
}

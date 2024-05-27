using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents;
public class Calculadora
{
    private List<string> _historico;
    public Calculadora()
    {
        _historico = new List<string>();
    }
    public int Somar(int val1, int val2)
    {
        var result = val1 + val2;
        _historico.Add($"Soma: {val1} + {val2} = {result}");
        return result;
    }
    public int Subtrair(int val1, int val2)
    {
        var result = val1 - val2;
        _historico.Add($"Subtração: {val1} - {val2} = {result}");
        return result;
    }
    public int Multiplicar(int val1, int val2)
    {
        var result = val1 * val2;
        _historico.Add($"Multiplicação: {val1} * {val2} = {result}");
        return result;
    }
    public int Dividir(int val1, int val2)
    {
        var result = val1 / val2;
        _historico.Add($"Divisão: {val1} / {val2} = {result}");
        return result;
    }
    public List<string> HistoricoOperacoes() 
    {
        _historico.Reverse();
        _historico.RemoveRange(3, _historico.Count-3);
        _historico.Reverse();
        return _historico;
    }
}

using System.Text;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.EntityFrameworkCore;
using VoeAirlines.Context;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels;

namespace VoeAirlines.Services
{
    public class ManutencaoService
    {
        private readonly IConverter _converter;
        private readonly VoeAirlinesContext _context;
        StringBuilder builder = new StringBuilder();

        public ManutencaoService(VoeAirlinesContext context,IConverter converter)
        {
            _context = context;
            _converter = converter;
        }

        public DetalhesManutencaoViewModel AdicionarManutencao(AdicionarManutencaoViewModel dados)
        {
            var manutencao = new Manutencao(dados.DataHora, dados.Tipo, dados.AeronaveId, dados.Observacao);

            _context.Add(manutencao);
            _context.SaveChanges();
            
            return new DetalhesManutencaoViewModel
            (
                manutencao.Id,
                manutencao.DataHora,
                manutencao.Tipo,
                manutencao.AeronaveId,
                manutencao.Observacao
            );
        }

        public IEnumerable<DetalhesManutencaoViewModel> DetalhesManutencoes(int aeronaveId)
        {
            return _context.Manutencoes.Where(m=>m.AeronaveId == aeronaveId)
                                        .Select(m=> new DetalhesManutencaoViewModel
                                        (
                                            m.Id,
                                            m.DataHora,
                                            m.Tipo,
                                            m.AeronaveId,
                                            m.Observacao
                                        )); 
        }
        public byte[]? GerarFichaManutencao(int id)
        {
            var manutencao = _context.Manutencoes.Include(m=>m.Aeronave)
                                                    .FirstOrDefault(m=>m.Id==id);
            
            if(manutencao!=null)
            {
                var tipo = "";
                if(manutencao.Tipo == 0)
                    tipo = "Preventiva";
                else
                    tipo = "Corretiva";
                builder.Append($"<h1 style='text-lign:center'>Ficha de Manutenção: {manutencao.Id.ToString().PadLeft(10,'0')}</h1>")
                        .Append($"<hr>")
                        .Append($"<div style='border-right: 5px solid black; height: 165px; position: absolute; right: 50%;'></div>");
                        if(manutencao.Tipo == 0)
                            builder.Append($"<p style='margin-right: 600px;'>Tipo Manutencao: <text style='color: green;'>{tipo}</text></p>");
                        else
                            builder.Append($"<p style='margin-right: 600px;'>Tipo Manutencao: <text style='color: red;'>{tipo}</text></p>")
                        .Append($"<p style='margin-right: 600px;'>Data: {manutencao.DataHora}</p>")
                        .Append($"<p style='margin-right: 600px;'>Observação: {manutencao.Observacao}</p>")
                        .Append($"<p style='margin-left: 600px;'>Aeronave: {manutencao.Aeronave.Modelo}</p>")
                        .Append($"<p style='margin-left: 600px;'>Fabricante: {manutencao.Aeronave.Fabricante}</p>")
                        .Append($"<p style='margin-left: 600px;'>Jatinho: {manutencao.Aeronave.Jatinho}</p>")
                        .Append($"<p style='margin-left: 600px;'>Codigo: {manutencao.Aeronave.Codigo}</p>");
                var doc = new HtmlToPdfDocument()
                {
                    GlobalSettings = 
                    {
                        ColorMode = ColorMode.Color,
                        Orientation = Orientation.Portrait,
                        PaperSize = PaperKind.A4
                    },
                    Objects = 
                    {
                        new ObjectSettings() 
                        {
                            PagesCount = true,
                            HtmlContent = builder.ToString(),
                            WebSettings = { DefaultEncoding = "utf-8" }
                        }
                    }
                };
                return _converter.Convert(doc);
            }
            return null;
        } 
    }
}
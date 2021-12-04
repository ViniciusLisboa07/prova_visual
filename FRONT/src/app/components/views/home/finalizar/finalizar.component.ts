import { Component, OnInit } from '@angular/core';
import { FormaPagamento } from 'src/app/models/forma-pagamento';
import { Venda } from 'src/app/models/venda';
import { FormaPagamentoService } from 'src/app/services/forma-pagemento.service';
import { VendaService } from 'src/app/services/venda.service';

@Component({
  selector: 'app-finalizar',
  templateUrl: './finalizar.component.html',
  styleUrls: ['./finalizar.component.css']
})
export class FinalizarComponent implements OnInit {

  nome!: string;
  formaPagamento!: FormaPagamento;
  formasDePagamentos: FormaPagamento[] = [];

  constructor(private serviceForma: FormaPagamentoService,
    private ServiceVenda: VendaService) { }

  ngOnInit(): void {
    this.serviceForma.list().subscribe((formas) => {
        this.formasDePagamentos = formas;
    });
  }

  cadastrarVenda(): void {
    let venda: Venda = {

    }


    this.ServiceVenda.create(venda).subscribe(() => {

    });
  }
}

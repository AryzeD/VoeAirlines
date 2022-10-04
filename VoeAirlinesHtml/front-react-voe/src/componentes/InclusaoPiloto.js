const InclusaoPiloto=()=>{
    return(
        <div className="container">
            <h4 className="fst-italic mt-3">Novo Piloto</h4>
            <form>
                <div className="form-group">
                    <input placeholder="Nome" type="text" className="form-control" id="nome" required autoFocus/>
                </div>
                <div className="form-group">
                    <input placeholder="Matricula" type="text" className="form-control" id="matricula" required/>
                </div>

                <input type="submit" className="btn btn-primary mt-3" value="Enviar"/>
                <input type="submit" className="btn btn-primary mt-3 ms-3" value="Limpar"/>
            </form>
            <div className="alert"></div>
        </div>
    );
};
export default InclusaoPiloto;
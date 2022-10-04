const MenuSuperior=()=>{
    
    return(
        
         <nav className="navbar navbar-expand-sm bg-primary navbar-dark sticky-top">

            <div className="container">
               <a className="navbar-brand" href="#">Cadastro de Pilotos</a>
               <ul className="navbar-nav">
                  
                  <li className="nav-item">
                      <a className="nav-link" href="#">Inclusão</a>
                  </li>
                  <li className="nav-item">
                  <li className="nav-item">
                      <a className="nav-link" href="#">Alteração</a>
                  </li>

                  </li>

                  <li className="nav-item">
                  <li className="nav-item">
                      <a className="nav-link" href="#">Resumo</a>
                  </li>
                  </li>
               </ul>
            </div>
         </nav>
    );
};
export default MenuSuperior;
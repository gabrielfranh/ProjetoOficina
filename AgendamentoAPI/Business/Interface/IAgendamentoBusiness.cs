﻿using AgendamentoAPI.DTO;

namespace AgendamentoAPI.Business.Interface
{
    public interface IAgendamentoBusiness
    {
        public Task<List<AgendamentoDTO>> GetAll();
        public Task<AgendamentoDTO> GetById(int id);
        public Task<AgendamentoDTO> Create(AgendamentoDTO agendamentoDTO);
        public Task<AgendamentoDTO> Update(AgendamentoDTO agendamentoDTO);
        public List<AgendamentoDTO> GetByDate(DateTime date);
        public Task<bool> Delete(int id);
    }
}
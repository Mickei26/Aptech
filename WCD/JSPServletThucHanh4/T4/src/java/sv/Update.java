package sv;

import ab.com.Student;
import java.io.IOException;
import java.io.PrintWriter;
import javax.persistence.EntityManager;
import javax.persistence.Persistence;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet(name = "Update", urlPatterns = {"/Update"})
public class Update extends HttpServlet {

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String id = request.getParameter("txtI");
        String name = request.getParameter("txtN");

        EntityManager em = Persistence.createEntityManagerFactory("JavaApplication43PU").createEntityManager();
        Student stu = em.find(Student.class, id);
        if (stu == null) {
            request.setAttribute("loi", "student voi id KOOO tontai, nen update lam sao duoc " + id);
            request.getRequestDispatcher("edit.jsp").forward(request, response);
        } else {
            stu.setName(name);

            // tất cả chức năng addnew/updawte/delete phải đưa vào trong transaction
            em.getTransaction().begin();
            em.merge(stu);
            em.getTransaction().commit();

            //addnew/update/xoa thanh cong xong thì quay về trang view.jsp để view all
            response.sendRedirect("ViewAll");
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}

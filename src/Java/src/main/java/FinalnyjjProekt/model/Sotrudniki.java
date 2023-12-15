package FinalnyjjProekt.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import FinalnyjjProekt.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import com.sap.olingo.jpa.metadata.core.edm.annotation.EdmIgnore;

/**
 * Entity implementation class for Entity: Сотрудники
 */
@Entity(name = "IISFinalnyjjProektСотрудники")
@Table(schema = "public", name = "Сотрудники")
public class Sotrudniki {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "Фамилия")
    private String фамилия;

    @Column(name = "СерияПас")
    private Integer серияпас;

    @Column(name = "КодСотру")
    private Integer кодсотру;

    @Column(name = "Имя")
    private String имя;

    @Column(name = "НомерПас")
    private Integer номерпас;

    @Column(name = "Отчество")
    private String отчество;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Otdely")
    @Convert("Otdely")
    @Column(name = "Отделы", length = 16, unique = true, nullable = false)
    private UUID _otdelyid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Otdely", insertable = false, updatable = false)
    private Otdely otdely;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Dolzhnosti")
    @Convert("Dolzhnosti")
    @Column(name = "Должности", length = 16, unique = true, nullable = false)
    private UUID _dolzhnostiid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Dolzhnosti", insertable = false, updatable = false)
    private Dolzhnosti dolzhnosti;


    public Sotrudniki() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public String getФамилия() {
      return фамилия;
    }

    public void setФамилия(String фамилия) {
      this.фамилия = фамилия;
    }

    public Integer getСерияПас() {
      return серияпас;
    }

    public void setСерияПас(Integer серияпас) {
      this.серияпас = серияпас;
    }

    public Integer getКодСотру() {
      return кодсотру;
    }

    public void setКодСотру(Integer кодсотру) {
      this.кодсотру = кодсотру;
    }

    public String getИмя() {
      return имя;
    }

    public void setИмя(String имя) {
      this.имя = имя;
    }

    public Integer getНомерПас() {
      return номерпас;
    }

    public void setНомерПас(Integer номерпас) {
      this.номерпас = номерпас;
    }

    public String getОтчество() {
      return отчество;
    }

    public void setОтчество(String отчество) {
      this.отчество = отчество;
    }


}
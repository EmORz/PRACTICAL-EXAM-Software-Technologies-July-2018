package issuetracker.entity;

import javax.persistence.*;
import javax.validation.constraints.NotNull;

@Entity
@Table(name = "issues")
public class Issue {

   // TODO:
   @Id
   @GeneratedValue(strategy = GenerationType.IDENTITY)
   private Integer id;

    @Column
    @NotNull
    private String title;

    @Column
    @NotNull
    private String content;

    @Column
    @NotNull
    private Integer priority;

    public Issue() {
    }

    public Issue(@NotNull String title, @NotNull String content, @NotNull Integer priority) {
        this.title = title;
        this.content = content;
        this.priority = priority;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @NotNull
    public String getTitle() {
        return title;
    }

    public void setTitle(@NotNull String title) {
        this.title = title;
    }

    @NotNull
    public String getContent() {
        return content;
    }

    public void setContent(@NotNull String content) {
        this.content = content;
    }

    @NotNull
    public Integer getPriority() {
        return priority;
    }

    public void setPriority(@NotNull Integer priority) {
        this.priority = priority;
    }
}
